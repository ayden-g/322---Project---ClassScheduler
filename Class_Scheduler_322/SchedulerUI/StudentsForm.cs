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

namespace SchedulerUI
{
    public partial class StudentsForm : Form
    {
        private bool studentCatalog = false;
        private bool studentSched = false;

        public StudentsForm(string userID)
        {
            InitializeComponent();
            txtUser.Text = userID;
            p1.Hide();
            p5.Hide();
            schedulePanel.Hide();
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

        private void studentCatalogBtn_Click(object sender, EventArgs e)
        {
            if (!studentCatalog)
            {
                disableSchedule();
                enableCatalog();
            }
            else
            {
                disableCatalog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentSearch_TextChanged(object sender, EventArgs e)
        {
            int temnp = panel3.Height;
            if (studentSearch.TextLength > 0)
            {
                searchPanel.Controls.Clear();
                SearchObject result = new SearchObject();
                result.CourseObjectName(studentSearch.Text);
                LoadResults();
                searchPanel.Height = searchPanel.Controls.Count * result.Height + 10;
            }
            else
            {
                searchPanel.Height = 0;
                searchPanel.Controls.Clear();

            }
        }

        private void studentScheduleBtn_Click(object sender, EventArgs e)
        {
            if (!studentSched)
            {
                disableCatalog();
                enableSchedule();
            }
            else
            {
                disableSchedule();
            }
        }

        private void enrollBtn_Click(object sender, EventArgs e)
        {
            if (SearchObject.clicked = true)
            {
                int targetNumber = SearchObject.courNum;
                Student student = new Student(txtUser.Text);
                string message = student.EnrollCourse(student.Id, targetNumber);

                if (message.Equals(String.Empty))
                { 
                    refreshCatalog();
                }
                else
                { 
                    MessageBox.Show(message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                }

            }
        }

        private void removeCourseFromSched_Click(object sender, EventArgs e)
        {
            Student student = new Student(txtUser.Text);
            int targetCourse = SearchObject.courNum;
            student.UnenrollCourse(student.Id, targetCourse);

            refreshSchedule();
        }

        private void enableCatalog()
        {
            searchPanel.Controls.Clear();
            studentCatalogBtn.Text = "Search";

            panel3.Hide();
            button3.Hide();
            studentSearch.Text = String.Empty;

            label1.Show();
            p5.Show();

            SearchObject result = new SearchObject();
            result.CourseObjectName("");
            LoadResults();
            searchPanel.Height = searchPanel.Controls.Count * result.Height;

            studentCatalog = true;
        }

        private void enableSchedule()
        {
            Student student = new Student(txtUser.Text);
            List<int> courseIds = student.GetEnrolledCourses(student.Id);

            studentScheduleBtn.Text = "Back";
            panel3.Hide();
            button3.Hide();
            p5.Hide();
            p1.Show();
            removeCourseFromSched.Show();
            studentSched = true;

            if (courseIds.Count() > 0)
            {
                SearchObject result = new SearchObject();
                result.CourseObjectId(courseIds);
                LoadResults();

                searchPanel.Height = searchPanel.Controls.Count * result.Height + 10;
            }
            else
            {
                MessageBox.Show("You aren't enrolled in any courses", "Empty Schedule", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void disableCatalog()
        {
            studentCatalogBtn.Text = "Catalog";

            p5.Hide();
            button3.Show();
            panel3.Show();

            searchPanel.Controls.Clear();
            searchPanel.Height = 0;

            studentCatalog = false;
        }

        private void disableSchedule()
        {
            studentScheduleBtn.Text = "Your Schedule";
            panel3.Show();
            button3.Show();
            panel3.Show();
            p1.Hide();
            schedulePanel.Hide();
            studentSched = false;
            searchPanel.Controls.Clear();
        }

        private void refreshCatalog()
        {
            disableCatalog();
            enableCatalog();
        }

        private void refreshSchedule()
        {
            disableSchedule();
            enableSchedule();
        }
    }
}
