using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using StudentDash;

namespace SchedulerUI
{
    public partial class LoginForm : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=Bisness2018!;database=scheduler_users");
        MySqlCommand cmd = new MySqlCommand();
        private string userID;
        private bool validUser = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string inputEmail = txtEmail.Text;
            string inputPass = txtPassword.Text;
            userID = inputEmail;


            if (string.IsNullOrWhiteSpace(inputEmail) || string.IsNullOrWhiteSpace(inputPass))
            {
                MessageBox.Show("Email or Password was left Balnk", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT * FROM users WHERE email_address = @Email AND acc_password = @Password";
            string queryStudents = "SELECT * FROM students WHERE e_mail = @Email AND student_id = @Password";



            using (con)
            {

                con.Open();
                using (cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Email", inputEmail);
                    cmd.Parameters.AddWithValue("@Password", inputPass);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read() == true)
                        {
                            MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            new SchedulerDashboard(userID).Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtEmail.Text = string.Empty;
                            txtPassword.Text = string.Empty;

                        }
                    }
                }
            }
        }

        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void toRegister_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
/*
using (MySqlCommand fetchCmd = new MySqlCommand(fetchQuery, con))
{
    using (MySqlDataReader fetchReader = fetchCmd.ExecuteReader())
    {
        string userData = "Users in Database:\n";
        while (fetchReader.Read())
        {
            string email = fetchReader["email_address"].ToString();
            string password = fetchReader["acc_password"].ToString();
            userData += $"Email: {email}, Password: {password}\n";
        }

        MessageBox.Show(userData, "Database Users", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
*/
