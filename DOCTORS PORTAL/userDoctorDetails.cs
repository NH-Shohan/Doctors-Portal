using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOCTORS_PORTAL
{
    public partial class userDoctorDetails : Form
    {
        userBookAppointment userBookAppointment = new userBookAppointment();
        public userDoctorDetails()
        {
            InitializeComponent();
        }

        private void userDoctorDetails_Load(object sender, EventArgs e)
        {
            pnlNav.Height = homeBtn.Height;
            pnlNav.Top = homeBtn.Top;
            pnlNav.Left = homeBtn.Left;
            homeBtn.BackColor = Color.FromArgb(75, 27, 151);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bookApointmentGoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            userBookAppointment.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {

        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {

        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {

        }

        private void contactBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
