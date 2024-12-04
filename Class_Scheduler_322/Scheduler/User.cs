using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class User
    {
        private string email;
    
        public User(string email)
        {
            this.email = email;
        }
    
        public string isValidated(MySqlConnection con)
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
                        if(count > 0)
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
    }
}
