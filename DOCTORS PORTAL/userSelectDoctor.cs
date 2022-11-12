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
    public partial class userSelectDoctor : Form
    {
        userDoctorDetails doctorDetails = new userDoctorDetails();
        public userSelectDoctor()
        {
            InitializeComponent();
        }

        public void loadUserForm(object Form)
        {
            this.Hide();

            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void userSelectDoctor_Load(object sender, EventArgs e)
        {
            pnlNav.Height = homeBtn.Height;
            pnlNav.Top = homeBtn.Top;
            pnlNav.Left = homeBtn.Left;
            homeBtn.BackColor = Color.FromArgb(75, 27, 151);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = homeBtn.Height;
            pnlNav.Top = homeBtn.Top;
            pnlNav.Left = homeBtn.Left;
            homeBtn.BackColor = Color.FromArgb(75, 27, 151);
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = dashboardBtn.Height;
            pnlNav.Top = dashboardBtn.Top;
            pnlNav.Left = dashboardBtn.Left;
            dashboardBtn.BackColor = Color.FromArgb(75, 27, 151);
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = aboutBtn.Height;
            pnlNav.Top = aboutBtn.Top;
            pnlNav.Left = aboutBtn.Left;
            aboutBtn.BackColor = Color.FromArgb(75, 27, 151);
        }

        private void contactBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = contactBtn.Height;
            pnlNav.Top = contactBtn.Top;
            pnlNav.Left = contactBtn.Left;
            contactBtn.BackColor = Color.FromArgb(75, 27, 151);
        }

        private void homeBtn_Leave(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.FromArgb(35, 7, 94);
        }

        private void dashboardBtn_Enter(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.FromArgb(35, 7, 94);
        }

        private void dashboardBtn_Leave(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.FromArgb(35, 7, 94);
            dashboardBtn.BackColor = Color.FromArgb(35, 7, 94);
        }

        private void aboutBtn_Leave(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.FromArgb(35, 7, 94);
            aboutBtn.BackColor = Color.FromArgb(35, 7, 94);
        }

        private void contactBtn_Leave(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.FromArgb(35, 7, 94);
            contactBtn.BackColor = Color.FromArgb(35, 7, 94);
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

        private void doctorDetailsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            doctorDetails.Show();
        }
    }
}
