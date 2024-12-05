using MySql.Data.MySqlClient;
using Scheduler;
using SchedulerUI;
using System.DirectoryServices;

namespace StudentDash
{
    public partial class SchedulerDashboard : Form
    {
        private bool catalog_Search = false;

        public SchedulerDashboard(string userID)
        {
            InitializeComponent();
            label1.Hide();
            panel1.Hide();
            panel5.Hide();
            txtUser.Text = userID;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            string userType = getUserType();

            if (userType == "Faculty")
            {
                new FacultyForm(txtUser.Text).Show();
                this.Hide();
            }
            else if (userType == "Student")
            {
                new StudentsForm(txtUser.Text).Show();
                this.Hide();
            }
            else if (userType == "Admin")
            {
                new AdminForm().Show();
                //new AdminForm(txtUser.Text).Show();
                this.Hide();
            }
        }

        private string getUserType()
        {
            string userType = string.Empty;
            string query = "SELECT user_type FROM users WHERE email_address = @Email";

            try
            {
                using (MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=EDCC-WWU-WSU-Underhill;database=scheduler_users"))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", txtUser.Text);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            userType = result.ToString();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message, "Query Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error: " + ex.Message, "Query Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return userType;
        }

        private void LoadResults()
        {
            foreach (Course course in Course.courseList)
            {
                SearchObject result = new SearchObject();
                result.SearchQuery(course);
                searchPanel.Controls.Add(result);
            }
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            int temnp = panel3.Height;
            if (searchText.TextLength > 0) {
                searchPanel.Controls.Clear();
                SearchObject result = new SearchObject();
                result.CourseObjectName(searchText.Text);
                LoadResults();
                searchPanel.Height = searchPanel.Controls.Count * result.Height + 10;
            }
            else
            {
                searchPanel.Height = 0;
            }
        }

        private void catalogBtn_Click(object sender, EventArgs e)
        {
            if (!catalog_Search)
            {
                searchPanel.Controls.Clear();
                catalogBtn.Text = "Search";

                panel3.Hide();
                searchText.Hide();
                button1.Hide();
                searchText.Text = String.Empty;

                label1.Show();
                panel1.Show();
                panel5.Show();

                SearchObject result = new SearchObject();
                result.CourseObjectName("");
                LoadResults();
                searchPanel.Height = searchPanel.Controls.Count * result.Height;

                catalog_Search = true;
            }
            else
            {

                catalogBtn.Text = "Catalog";

                label1.Hide();
                panel1.Hide();
                panel5.Hide();

                panel3.Show();
                searchText.Show();
                button1.Show();
                searchPanel.Controls.Clear();
                searchPanel.Height = 0;

                catalog_Search = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}