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

namespace StudentDash
{
    public partial class SearchObject : UserControl
    {
        public static bool clicked = false;
        public bool selectedCourse = false;
        public int courseId;
        public static int courNum;


        public SearchObject()
        {
            InitializeComponent();
        }

        private void SearchObject_Load(object sender, EventArgs e)
        {

        }

        public void SearchQuery(Course course)
        {
            lCourseNum.Text = course.CourseNumber.ToString();
            lName.Text = course.Name;
            lSection.Text = course.Section;
            lInstructor.Text = course.Instructor;
            lSeats.Text = course.Seating.ToString();
            lStartTime.Text = course.StartTime.ToString();
            lEndTime.Text = course.EndTime.ToString();
            lMeetingDays.Text = course.MeetingDays;
            courseId = course.CourseNumber;
        }

        public void CourseObjectName(string searchKey)
        {
            Course course = new Course();
            course.searchCourse(searchKey);
            lCourseNum.Text = course.CourseNumber.ToString();
            lName.Text = course.Name;
            lSection.Text = course.Section;
            lInstructor.Text = course.Instructor;
            lSeats.Text = course.Seating.ToString();
            lStartTime.Text = course.StartTime.ToString();
            lEndTime.Text = course.EndTime.ToString();
            lMeetingDays.Text = course.MeetingDays;

        }

        public void CourseObjectInstructor(string searchKey)
        {
            Course course = new Course();
            course.searchCourseByInstructor(searchKey);
            lCourseNum.Text = course.CourseNumber.ToString();
            lName.Text = course.Name;
            lSection.Text = course.Section;
            lInstructor.Text = course.Instructor;
            lSeats.Text = course.Seating.ToString();
            lStartTime.Text = course.StartTime.ToString();
            lEndTime.Text = course.EndTime.ToString();
            lMeetingDays.Text = course.MeetingDays;

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            if (!clicked)
            {
                panel1.BackColor = Color.DarkGray;
                panel1.ForeColor = Color.Black;
            }
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            if (!clicked)
            {
                panel1.BackColor = Color.WhiteSmoke;
                panel1.ForeColor = Color.Black;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (!clicked)
            {
                clicked = true;
                panel1.BackColor = Color.Firebrick;
                panel1.ForeColor = Color.WhiteSmoke;

                courNum = courseId;
            }
            else
            {
                clicked = false;

                courNum = 0;
            }
        }
    }
}
