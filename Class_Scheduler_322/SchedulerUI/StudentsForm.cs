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
            else
            {

                studentCatalogBtn.Text = "Catalog";

                p5.Hide();
                button3.Show();
                panel3.Show();



                searchPanel.Controls.Clear();
                searchPanel.Height = 0;

                studentCatalog = false;
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
            }
        }

        private void studentScheduleBtn_Click(object sender, EventArgs e)
        {
            if (!studentSched)
            {
                panel3.Hide();
                button3.Hide();
                p5.Hide();
                p1.Show();
                schedulePanel.Show();
                removeCourseFromSched.Show();
                studentSched = true;
            }
            else
            {
                panel3.Show();
                button3.Show();
                panel3.Show();
                p1.Hide();
                schedulePanel.Hide();
                studentSched = false;

            }
        }

        private void enrollBtn_Click(object sender, EventArgs e)
        {
            if (SearchObject.clicked = true)
            {
                int targetNumber = SearchObject.courNum;
                Student student = new Student();
                student.SearchStudentByEmail(txtUser.Text);
                //Student enrollStudent = student;
                student.EnrollStudent(student.Id, targetNumber);
            }
        }

        private void removeCourseFromSched_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student = student.SearchStudentByEmail(txtUser.Text);
            int targetCourse = SearchObject.courNum;
            int targetID = student.Id;
            student.UnenrollStudent(targetID, targetCourse);

            SearchObject.courNum = 0;

        }
    }
}
