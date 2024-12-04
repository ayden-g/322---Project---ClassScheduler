using System;
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
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            string query = "INSERT INTO enrolled_courses (student_id, course_id) VALUES (@StudentId, @CourseNumber)";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@StudentId", studentID);
                command.Parameters.AddWithValue("@CourseNumber", courseNumber);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Student successfully enrolled into the course");
                }
                else
                {
                    Console.WriteLine("Failed to enroll");
                }
            }

        }

        public void UnenrollStudent(int studentID, int ccourseID)
        {
            MySqlConnection connection = new MySqlConnection(con);
            connection.Open();
            string query = "DELETE FROM enrolled_courses WHERE studentid = @StudentId AND courseid = @CourseId";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@StudentId", studentID);
                command.Parameters.AddWithValue("@CourseNumber", ccourseID);
                command.ExecuteNonQuery();

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
    }
}
