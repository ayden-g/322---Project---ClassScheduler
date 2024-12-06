using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class User
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }

        public static List<User> userList = new List<User>();


        public User() { }

        public string isValidated(MySqlConnection con, string email)
        {
            string validateQuery = "SELECT COUNT(*) FROM wsu_users WHERE e_mail = @Email";

            try
            {
                using (con)
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(validateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                            return "True";
                        else
                            return "False";
                    }
                }
            }
            catch (MySqlException ex)
            {
                return ex.Message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void searchFaculty(string userType)
        {
            using (MySqlConnection connection = new MySqlConnection(Scheduler.Connection.DB_STRING))
            {
                connection.Open();

                string query = "SELECT * FROM users WHERE user_type LIKE @UserType";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserType", userType + "%");

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User
                            {
                                EmailAddress = reader["email_address"].ToString(),
                                Password = reader["acc_password"].ToString(),
                                UserType = reader["user_type"].ToString()
                            };

                            userList.Add(user);
                        }
                    }
                }
            }
        }
    }

}
