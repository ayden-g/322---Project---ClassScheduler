using Microsoft.VisualBasic.ApplicationServices;
using Scheduler;
using StudentDash;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = Scheduler.User;

namespace SchedulerUI
{
    public partial class AdminForm : Form
    {

        public AdminForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadResults()
        {
            foreach (Course course in Course.courseList)
            {
                SearchObject result = new SearchObject();
                result.SearchQuery(course);
                displayPanel.Controls.Add(result);
            }
        }

        private void Courses_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            label1.Text = "Courses";
            SearchObject result = new SearchObject();
            result.CourseObjectName("");
            LoadResults();
            displayPanel.Height = displayPanel.Controls.Count * result.Height;
        }

        private void LoadResults_Faculty()
        {
            foreach (User user in User.userList)
            {
                UserControl result = new UserControl();
                result.SearchUserQuery(user);
                displayPanel.Controls.Add(result);
            }
        }

        private void Faculty_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            UserControl result = new UserControl();
            result.UserObjectType("faculty");
            LoadResults_Faculty();
            displayPanel.Height = displayPanel.Controls.Count * result.Height;
            User.userList.Clear();
        }

        private void Students_Click(object sender, EventArgs e)
        {
            displayPanel.Controls.Clear();
            UserControl result = new UserControl();
            result.UserObjectType("Student");
            LoadResults_Faculty();
            displayPanel.Height = displayPanel.Controls.Count * result.Height;
            User.userList.Clear();

        }

        private void deleteAnything_Click(object sender, EventArgs e)
        {
            string targetEmail = UserControl.selectedEmail;
            int targetCourse = SearchObject.courNum;

            // Debugging: Ensure target values are correct
            MessageBox.Show("Deleting user with email: " + targetEmail);
            MessageBox.Show("Deleting course with ID: " + targetCourse);

            Admin admin = new Admin();
            admin.DeleteAccount(targetEmail);
            admin.DeleteCourse(targetCourse);

            UserControl.selectedEmail = "";
            SearchObject.courNum = 0;

            MessageBox.Show("Deletion Successful");
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
