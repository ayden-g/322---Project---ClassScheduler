using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Scheduler
{
    public class Course
    {
        string con = ("server=localhost;uid=root;pwd=Bisness2018!;database=scheduler_users");

        public string Name { get; set; }
        public string Instructor { get; set; }
        public int Seating { get; set; }
        public int CourseNumber { get; set; }
        public string Section { get; set; }
        public string MeetingDays { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

        public static List<Course> courseList = new List<Course>();

        public void searchCourse(string course)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();

                string query = "SELECT * FROM courses WHERE course_name LIKE @CourseName";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CourseName", course + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        courseList.Clear();

                        while (reader.Read())
                        {
                            Course searchCourse = new Course
                            {
                                CourseNumber = Convert.ToInt32(reader["course_number"]),
                                Name = reader["course_name"].ToString(),
                                Section = reader["course_section"].ToString(),
                                Instructor = reader["course_instructor"].ToString(),
                                Seating = Convert.ToInt32(reader["course_seats"]),
                                StartTime = TimeOnly.Parse(reader["start_time"].ToString()),
                                EndTime = TimeOnly.Parse(reader["end_time"].ToString()),
                                MeetingDays = reader["meeting_days"].ToString()
                            };
                            courseList.Add(searchCourse);
                        }
                    }
                }
            }
        }

        public void searchCourseByInstructor(string course)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();

                string query = "SELECT * FROM courses WHERE course_instructor LIKE @Instructor";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Instructor", course + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        courseList.Clear();

                        while (reader.Read())
                        {
                            Course searchCourse = new Course
                            {
                                CourseNumber = Convert.ToInt32(reader["course_number"]),
                                Name = reader["course_name"].ToString(),
                                Section = reader["course_section"].ToString(),
                                Instructor = reader["course_instructor"].ToString(),
                                Seating = Convert.ToInt32(reader["course_seats"]),
                                StartTime = TimeOnly.Parse(reader["start_time"].ToString()),
                                EndTime = TimeOnly.Parse(reader["end_time"].ToString()),
                                MeetingDays = reader["meeting_days"].ToString()
                            };
                            courseList.Add(searchCourse);
                        }
                    }
                }
            }
        }

        public void CreateCourse(Course course)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con))
                {
                    connection.Open();
                    string query = "INSERT INTO courses (course_number, course_name, course_section, course_instructor, course_seats, start_time, end_time, meeting_days) VALUES (@Number, @Name, @Section, @Instructor, @Seating, @StartTime, @EndTime, @MeetingDays)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Number", course.CourseNumber);
                        cmd.Parameters.AddWithValue("@Name", course.Name);
                        cmd.Parameters.AddWithValue("@Section", course.Section);
                        cmd.Parameters.AddWithValue("@Instructor", course.Instructor);
                        cmd.Parameters.AddWithValue("@Seating", course.Seating);
                        cmd.Parameters.AddWithValue("@StartTime", course.StartTime.ToString("HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@EndTime", course.EndTime.ToString("HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@MeetingDays", course.MeetingDays);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating course: {ex.Message}");
            }
        }

        public Course GetCourse(int id)
        {
            Course course = new Course();

            using (MySqlConnection connection = new MySqlConnection(con))
            {
                connection.Open();
                string sql = "SELECT * FROM courses WHERE course_number = @Number";
                using (MySqlCommand com = new MySqlCommand(sql, connection))
                {
                    com.Parameters.AddWithValue("@Number", id);

                    using (MySqlDataReader reader = com.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            {
                                course.CourseNumber = reader.GetInt32("course_number");
                                course.Name = reader.GetString("course_name");
                                course.Section = reader.GetString("course_section");
                                course.Instructor = reader.GetString("course_instructor");
                                course.Seating = reader.GetInt32("course_seats");
                                course.StartTime = TimeOnly.Parse(reader.GetString("start_time"));
                                course.EndTime = TimeOnly.Parse(reader.GetString("end_time"));
                                course.MeetingDays = reader.GetString("meeting_days");
                            }
                        }
                    }
                }
            }

            return course;
        }

        public void EditCourse(Course course)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con))
                {
                    connection.Open();
                    string query = "UPDATE courses SET course_name = @Name, course_section = @Section, course_seats = @Seating, start_time = @StartTime, end_time = @EndTime, meeting_days = @MeetingDays WHERE course_number = @Number";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Number", course.CourseNumber);
                        cmd.Parameters.AddWithValue("@Name", course.Name);
                        cmd.Parameters.AddWithValue("@Section", course.Section);
                        cmd.Parameters.AddWithValue("@Instructor", course.Instructor);
                        cmd.Parameters.AddWithValue("@Seating", course.Seating);
                        cmd.Parameters.AddWithValue("@StartTime", course.StartTime.ToString("HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@EndTime", course.EndTime.ToString("HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@MeetingDays", course.MeetingDays);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating course: {ex.Message}");
            }
        }

        public void DeleteCourse(int courseNumber)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con))
                {
                    connection.Open();
                    string query = "DELETE FROM courses WHERE course_number = @CourseNumber";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@CourseNumber", courseNumber);
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
            }
        }



    }
}
