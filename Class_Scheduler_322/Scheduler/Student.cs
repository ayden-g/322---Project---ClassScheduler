using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Google.Protobuf.WellKnownTypes;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Collections.Specialized.BitVector32;

namespace Scheduler
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }


        public Student(string email)
        {
            InitStudentByEmail(email);
        }

        public string EnrollCourse(int studentID, int courseNumber)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(Scheduler.Connection.DB_STRING))
                {
                    connection.Open();

                    // If the student isnt already enrolled to the course.
                    if (!GetEnrolledCourses(studentID).Contains(courseNumber))
                    {
                        // If the course has avaible seats.
                        if (NumberOfSeatsAvailable(connection, courseNumber) > 0)
                        {
                            // If the course doesn't conflict with other enrolled courses.
                            string isConflicting = FindConfliction(courseNumber);
                            if (isConflicting == String.Empty)
                            {
                                // Enroll student in course
                                string query = "INSERT INTO enrolled_courses (student_id, course_id) VALUES (@StudentId, @CourseNumber)";
                                using (MySqlCommand command = new MySqlCommand(query, connection))
                                {
                                    command.Parameters.AddWithValue("@StudentId", studentID);
                                    command.Parameters.AddWithValue("@CourseNumber", courseNumber);
                                    command.ExecuteNonQuery();

                                    UpdateSeating(connection, courseNumber, -1);
                                }
                            }
                            else
                            {
                                return "This course conflicts with your schedule!\n\nConflicting with course: " + isConflicting;
                            }
                        }
                        else
                        {
                            return "The course is full!";
                        }
                    }
                    else 
                    {
                        return "You are already enrolled for the course!";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error Enrolling in course: {ex.Message}";
            }

            return String.Empty;
        }

        public void UnenrollCourse(int studentID, int courseID)
        {
            using (MySqlConnection connection = new MySqlConnection(Scheduler.Connection.DB_STRING))
            {
                connection.Open();

                string query = "DELETE FROM enrolled_courses WHERE student_id = @StudentId AND course_id = @CourseId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", studentID);
                    command.Parameters.AddWithValue("@CourseId", courseID);

                    int rowsAffected = command.ExecuteNonQuery();
                    if(rowsAffected > 0)
                    {
                        UpdateSeating(connection, courseID, 1);
                    }
                }
            }
        }

        private void InitStudentByEmail(string email)
        {
            MySqlConnection connection = new MySqlConnection(Scheduler.Connection.DB_STRING);
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
            }

            return seatsAvailable;
        }

        private void UpdateSeating(MySqlConnection con, int courseNumber, int seatAdjustment)
        {
            string query = "UPDATE courses SET course_seats = course_seats + @SeatAdjustment WHERE course_number = @CourseNumber;";
            using (MySqlCommand command = new MySqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@CourseNumber", courseNumber);
                command.Parameters.AddWithValue("@SeatAdjustment", seatAdjustment);
                command.ExecuteNonQuery();
            }
        }

        // Gets the first enrolled course that conflicts with the given course.
        private string FindConfliction(int newCourse)
        {
            List<int> courseIds = GetEnrolledCourses(Id);

            // Fetch details for the new course.
            (TimeOnly newStartTime, TimeOnly newEndTime, string newMeetingDays, string newname, string newcourseNumber, string newsection) = GetCourseDetails(newCourse);

            // Compare the new course with each enrolled course.
            foreach (int courseId in courseIds)
            {
                (TimeOnly startTime, TimeOnly endTime, string meetingDays, string name, string courseNumber, string section) = GetCourseDetails(courseId);

                if (IsSameDay(newMeetingDays, meetingDays) && IsSameTime(newStartTime, startTime, newEndTime, endTime))
                {
                    return $"{name} ({courseNumber}), Section {section}";
                }
            }

            return string.Empty;
        }

        // Helper method to get course details by courseId.
        private (TimeOnly StartTime, TimeOnly EndTime, string MeetingDays, string Name, string CourseNumber, string Section) GetCourseDetails(int courseId)
        {
            using (MySqlConnection connection = new MySqlConnection(Scheduler.Connection.DB_STRING))
            {
                connection.Open();
                string query = "SELECT * FROM courses WHERE course_number = @CourseId;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourseId", courseId);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TimeOnly startTime = TimeOnly.Parse(reader["start_time"].ToString());
                            TimeOnly endTime = TimeOnly.Parse(reader["end_time"].ToString());
                            string meetingDays = reader["meeting_days"].ToString();
                            string name = reader["course_name"].ToString();
                            string courseNumber = reader["course_number"].ToString();
                            string section = reader["course_section"].ToString();

                            return (startTime, endTime, meetingDays, name, courseNumber, section);
                        }
                        else
                        {
                            throw new Exception("Course not found.");
                        }
                    }
                }
            }
        }

        private bool IsSameDay(string newDays, string days)
        {
            List<string> newDaysList = newDays.Split(", ").ToList();
            List<string> daysList = days.Split(", ").ToList();

            foreach (string day in newDaysList)
            {
                if (daysList.Contains(day))
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsSameTime(TimeOnly newStart, TimeOnly start, TimeOnly newEnd, TimeOnly end)
        {
            //bool isNewStartConflict = newStart < end && newEnd > start;
            //bool isNewEndConflict = start > newEnd && end < newStart;

            //return isNewStartConflict || isNewEndConflict;
            return newStart < end && newEnd > start;
        }

        public List<int> GetEnrolledCourses(int studentId)
        {
            List<int> courseIds = new List<int>();

            using (MySqlConnection connection = new MySqlConnection(Scheduler.Connection.DB_STRING))
            {
                connection.Open();

                string query = "SELECT course_id FROM enrolled_courses WHERE student_id = @StudentId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", studentId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            courseIds.Add(reader.GetInt32("course_id"));
                        }
                    }
                }
            }

            return courseIds;
        }
    }
}
