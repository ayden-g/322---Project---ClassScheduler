using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Scheduler
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        string con = "server=localhost;uid=root;pwd=Bisness2018!;database=scheduler_users";

        public Student()
        {

        }

        public void EnrollStudent(int studentID, int courseNumber)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con))
                {
                    connection.Open();

                    if (NumberOfSeatsAvailable(connection, courseNumber) > 0)
                    {
                        // Enroll student in course
                        string query = "INSERT INTO enrolled_courses (student_id, course_id) VALUES (@StudentId, @CourseNumber)";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@StudentId", studentID);
                            command.Parameters.AddWithValue("@CourseNumber", courseNumber);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                Console.WriteLine("Student successfully enrolled into the course");

                                // Update seating
                                UpdateSeating(connection, courseNumber);
                            }
                            else
                            {
                                Console.WriteLine("Failed to enroll");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No available seats to enroll");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Enrolling in course: {ex.Message}");
            }
        }

        public Student SearchStudentByEmail(string email)
        {
            Student student = new Student();

            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();

            string query = "SELECT * FROM students WHERE e_mail = @Email;";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", email);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Id = reader.GetInt32("student_id");
                            FirstName = reader.GetString("first_name");
                            LastName = reader.GetString("last_name");
                            Email = reader.GetString("e_mail");
                        }
                    }
                }
            }
            
            return student;
        }

        private int NumberOfSeatsAvailable(MySqlConnection con, int courseNumber)
        {
            int seatsAvailable = 0;

            string query = "SELECT course_seats FROM courses WHERE course_number = @CourseNumber;";
            using (MySqlCommand command = new MySqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@CourseNumber", courseNumber);

                var res = command.ExecuteScalar();
                if (res != DBNull.Value)
                    seatsAvailable = Convert.ToInt32(res);
                else
                    Console.WriteLine("Failed to find seating for class");
            }

            return seatsAvailable;
        }

        private void UpdateSeating(MySqlConnection con, int courseNumber)
        {
            string query = "UPDATE courses SET course_seats = course_seats - 1 WHERE course_number = @CourseNumber;";
            using (MySqlCommand command = new MySqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@CourseNumber", courseNumber);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Course seating adjusted");
                }
                else
                {
                    Console.WriteLine("Failed to update seating");
                }
            }
        }
    }
}
