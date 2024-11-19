using Scheduler;
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
    public partial class CreationForm : Form
    {
        private string createInstructor;
        public CreationForm(string userID)
        {
            InitializeComponent();
            createInstructor = userID;
        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Course newCourse = new Course();
            if (!string.IsNullOrWhiteSpace(createNumber.Text))
            {
                newCourse.CourseNumber = Convert.ToInt32(createNumber.Text);
            }
            else
            {
                MessageBox.Show("Course number was left blank", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(createName.Text))
            {
                newCourse.Name = createName.Text;
            }
            else
            {
                MessageBox.Show("Course name was left blank", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(createName.Text))
            {
                newCourse.Section = createSection.Text;
            }
            else
            {
                MessageBox.Show("Course section was left blank", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(createSeating.Text))
            {
                newCourse.Seating = Convert.ToInt32(createSeating.Text);
            }
            else
            {
                MessageBox.Show("Course size was left blank", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(createStart.Text))
            {
                newCourse.StartTime = TimeOnly.Parse(createStart.Text);
            }
            else
            {
                MessageBox.Show("Course start time was left blank", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(createEnd.Text))
            {
                newCourse.EndTime = TimeOnly.Parse(createEnd.Text);
            }
            else
            {
                MessageBox.Show("Course end time was left blank", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(createDays.Text))
            {
                newCourse.MeetingDays = createDays.Text;
            }
            else
            {
                MessageBox.Show("Meeting days were left blank", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            newCourse.Instructor = createInstructor;
            newCourse.CreateCourse(newCourse);

            MessageBox.Show("Creation Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            createName.Text = string.Empty;
            createNumber.Text = string.Empty;
            createDays.Text = string.Empty;
            createEnd.Text = string.Empty;
            createStart.Text = string.Empty;
            createSection.Text = string.Empty;
            createSeating.Text = string.Empty;
        }

        private void CreationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
