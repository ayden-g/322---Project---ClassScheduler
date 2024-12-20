﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Scheduler;

namespace SchedulerUI
{
    public partial class RegisterForm : Form
    {

        MySqlConnection con = new MySqlConnection(Connection.DB_STRING);
        MySqlCommand cmd = new MySqlCommand();

        public RegisterForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string inputEmail = txtEmail.Text;
            string inputPass = txtPassword.Text;
            string userType = txtUserType.Text;

            if (string.IsNullOrWhiteSpace(inputEmail) || string.IsNullOrWhiteSpace(inputPass) || string.IsNullOrWhiteSpace(userType))
            {
                MessageBox.Show("Email or Password was left blank", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (userType != "Faculty" && userType != "Student" && userType != "Admin")
            {
                MessageBox.Show("User Type was not (Student/Faculty/Admin),", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserType.Text = String.Empty;
                return;
            }

            if (txtPassword.Text != txtPasswordVerify.Text)
            {
                MessageBox.Show("Passwords do not match,", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Text = String.Empty;
                txtPasswordVerify.Text = String.Empty;
                return;
            }

            User user = new User();
            string res = user.isValidated(con, inputEmail);
            if (res == "False")
            {
                MessageBox.Show("User not in WSU system,", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (res != "True")
            {
                MessageBox.Show("MySQL Error: " + res, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO users (email_address, acc_password, user_type) VALUES (@Email, @Password, @UserType)";
            try
            {
                using (con)
                {
                    con.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", inputEmail);
                        cmd.Parameters.AddWithValue("@Password", inputPass);
                        cmd.Parameters.AddWithValue("@UserType", userType);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User Registered Successfully", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (userType == "Student")
                    {
                        query = "INSERT INTO students (student_id, first_name, last_name, e_mail) VALUES (@Id, @Fname, @Lname, @Email)";
                        using (MySqlCommand cmd = new MySqlCommand(query, con))
                        {
                            Random random = new Random();
                            int randomID = random.Next(1, 99999999);

                            cmd.Parameters.AddWithValue("@Id", randomID);
                            cmd.Parameters.AddWithValue("@Fname", "FirstName");
                            cmd.Parameters.AddWithValue("@Lname", "LastName");
                            cmd.Parameters.AddWithValue("@Email", inputEmail);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    backToLoginBtn_Click(sender, e);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error: " + ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backToLoginBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtPasswordVerify.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtPasswordVerify.PasswordChar = '•';
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
