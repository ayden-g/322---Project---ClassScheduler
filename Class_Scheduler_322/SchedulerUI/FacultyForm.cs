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
    public partial class FacultyForm : Form
    {
        private bool edit_Course = false;
        private string id; 

        public FacultyForm(string userID)
        {
            InitializeComponent();
            txtUser.Text = userID;
            id = userID;
            l1.Hide();
            p1.Hide();
            editCourseBtn.Hide();
            editPanel.Hide();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            CreationForm creation = new CreationForm(txtUser.Text);
            creation.StartPosition = FormStartPosition.Manual;
            creation.Location = new Point(
                this.Location.X + (this.Width - creation.Width) / 2,
                this.Location.Y + (this.Height - creation.Height) / 2
            );
            creation.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadResults_Faculty()
        {
            foreach (Course course in Course.courseList)
            {
                SearchObject result = new SearchObject();
                result.SearchQuery(course);
                myCoursePanel.Controls.Add(result);
            }
        }

        private void myCourseBtn_Click(object sender, EventArgs e)
        {
            if (!edit_Course)
            {
                l1.Show();
                p1.Show();
                editCourseBtn.Show();

                SearchObject result = new SearchObject();
                result.CourseObjectInstructor(txtUser.Text);
                LoadResults_Faculty();
                myCoursePanel.Height = myCoursePanel.Controls.Count * result.Height + 10;
                edit_Course = true;

            }
            else
            {
                l1.Hide();
                p1.Hide();
                editCourseBtn.Hide();

                myCourseBtn.Show();
                createCourseBtn.Show();

                myCoursePanel.Height = 0;
                edit_Course = false;


            }
        }

        private void dashBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SchedulerDashboard dash = new SchedulerDashboard(id);
            dash.StartPosition = FormStartPosition.CenterScreen;
            dash.Show();
        }

        private void editCourseBtn_Click(object sender, EventArgs e)
        {
            if (SearchObject.clicked = true)
            {
                int targetNumber = SearchObject.courNum;
                editPanel.Show();
                Course course = new Course();
                Course editCourse = course.GetCourse(targetNumber);

                editDays.Text = editCourse.MeetingDays;
                editName.Text = editCourse.Name;
                editSeating.Text = editCourse.Seating.ToString();
                editSection.Text = editCourse.Section;
                editStart.Text = editCourse.StartTime.ToString();
                editEnd.Text = editCourse.EndTime.ToString();
                editNumber.Text = editCourse.CourseNumber.ToString();
            }
        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            editPanel.Show();
        }

        private void confirmEditBtn_Click(object sender, EventArgs e)
        {
            Course editCourse = new Course
            {
                MeetingDays = editDays.Text,
                Name = editName.Text,
                Seating = Convert.ToInt32(editSeating.Text),
                Section = editSection.Text,
                StartTime = TimeOnly.Parse(editStart.Text),
                EndTime = TimeOnly.Parse(editEnd.Text),
                CourseNumber = Convert.ToInt32(editNumber.Text)
            };

            editCourse.EditCourse(editCourse);
            MessageBox.Show("Course updated successfully!");
            editPanel.Hide();
        }

        private void deleteCourseBtn_Click(object sender, EventArgs e)
        {
            if (SearchObject.clicked = true)
            {
                int targetNumber = SearchObject.courNum;
                editPanel.Show();
                Course course = new Course();
                course.DeleteCourse(targetNumber);
                Course.courseList.Clear();
                MessageBox.Show("Course deleted successfully!");
                editPanel.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
