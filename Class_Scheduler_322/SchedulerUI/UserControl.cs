using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Scheduler;

namespace SchedulerUI
{
    public partial class UserControl : System.Windows.Forms.UserControl
    {
        public static bool clicked = false;
        public bool selectedUser = false;
        public string e_mail;
        public static string selectedEmail;

        public UserControl()
        {
            InitializeComponent();
        }

        private void SearchObject_Load(object sender, EventArgs e)
        {
        }

        public void SearchUserQuery(User user)
        {
            email_address.Text = user.EmailAddress;
            userType.Text = user.UserType;
            password.Text = user.Password;
            e_mail = user.EmailAddress;
        }

        public void UserObjectEmail(string searchKey)
        {
            User user = new User();
            user.searchFaculty(searchKey);
            email_address.Text = user.EmailAddress;
            userType.Text = user.UserType;
        }

        public void UserObjectType(string searchKey)
        {
            User user = new User();
            user.searchFaculty(searchKey);
            email_address.Text = user.EmailAddress;
            userType.Text = user.UserType;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
                panel2.BackColor = Color.DarkGray;
                panel2.ForeColor = Color.Black;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.WhiteSmoke;
            panel2.ForeColor = Color.Black;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Firebrick;
            selectedEmail = e_mail;

        }
    }
}
