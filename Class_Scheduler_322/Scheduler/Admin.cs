using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class Admin
    {

        string con = ("server=localhost;uid=root;pwd=EDCC-WWU-WSU-Underhill;database=scheduler_users");

        public void DeleteAccount(string email)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con))
                {
                    connection.Open();

                    string query = "DELETE FROM users WHERE email_address = @EmailAddress";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@EmailAddress", email);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void DeleteCourse(int courseNumber)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con))
                {
                    connection.Open();

                    string deleteEnrolledCoursesQuery = "DELETE FROM enrolled_courses WHERE course_id = @CourseNumber";
                    using (MySqlCommand cmd1 = new MySqlCommand(deleteEnrolledCoursesQuery, connection))
                    {
                        cmd1.Parameters.AddWithValue("@CourseNumber", courseNumber);
                        cmd1.ExecuteNonQuery();
                    }

                    string deleteCourseQuery = "DELETE FROM courses WHERE course_number = @CourseNumber";
                    using (MySqlCommand cmd2 = new MySqlCommand(deleteCourseQuery, connection))
                    {
                        cmd2.Parameters.AddWithValue("@CourseNumber", courseNumber);
                        cmd2.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
            }
        }

    }
}
