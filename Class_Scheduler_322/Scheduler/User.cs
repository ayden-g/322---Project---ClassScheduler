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

        string con = "server=localhost;uid=root;pwd=Bisness2018!;database=scheduler_users";

        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }

        public static List<User> userList = new List<User>();


        public User() { }

        public void searchFaculty(string userType)
        {
            using (MySqlConnection connection = new MySqlConnection(con))
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
                                EmailAddress = reader["email_adress"].ToString(),
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
