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
    public partial class UserHome : Form
    {
        userSelectDoctor userSelectDoctor = new userSelectDoctor();
        private DataSet dsObj { get; set; }

        private DataAccess Da { get; set; }

        public Panel MainPanel {
            get { return mainPanel; }
            set { }
        }

        /*public void loadform(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form);
            this.mainPanel.Tag = form;
            form.Show();
        }*/

        public UserHome()
        {

            InitializeComponent();

            Da = new DataAccess();

            HomeSectionTest userHomeSectionObj = new HomeSectionTest(MainPanel);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(userHomeSectionObj);
            userHomeSectionObj.Show();

        }
        
        public UserHome(DataSet dsObj)
        {
            InitializeComponent();
            HomeSectionTest userHomeSectionObj = new HomeSectionTest(MainPanel);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(userHomeSectionObj);
            userHomeSectionObj.Show();
            // From Login
            this.dsObj = dsObj;
            showEmail.Text = dsObj.Tables[0].Rows[0]["email"].ToString();
            showName.Text = dsObj.Tables[0].Rows[0]["name"].ToString();
            homeBtn.PerformClick();
        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            pnlNav.Height = homeBtn.Height;
            pnlNav.Top = homeBtn.Top;
            pnlNav.Left = homeBtn.Left;
            homeBtn.BackColor = Color.FromArgb(75, 27, 151);

           // loadform(new userHomeSection());
            
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = homeBtn.Height;
            pnlNav.Top = homeBtn.Top;
            homeBtn.BackColor = Color.FromArgb(75, 27, 151);

            // loadform(new userSelectDoctorSection());
            // loadform(new userHomeSection());

            HomeSectionTest userHomeSectionObj = new HomeSectionTest(MainPanel);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(userHomeSectionObj);
            userHomeSectionObj.Show();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = dashboardBtn.Height;
            pnlNav.Top = dashboardBtn.Top;
            dashboardBtn.BackColor = Color.FromArgb(75, 27, 151);

           // loadform(new userDashboardSection());
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = aboutBtn.Height;
            pnlNav.Top = aboutBtn.Top;
            aboutBtn.BackColor = Color.FromArgb(75, 27, 151);
        }

        private void contactBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = contactBtn.Height;
            pnlNav.Top = contactBtn.Top;
            contactBtn.BackColor = Color.FromArgb(75, 27, 151);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else if(this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized ;
        }

        private void dhakaBtn_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            userSelectDoctor.Show();*/
            /*string sql = "insert into [DoctorsPortal].[dbo].[user] (id, name, password, email) values ('006', 'Md Saimon Bolda', 'jjs123456', 'jitu@gmail.com');";
            Da.ExecuteQuery(sql);*/
        }

        private void homeBtn_Leave(object sender, EventArgs e)
        {
            homeBtn.BackColor = Color.FromArgb(35, 7, 94);
        }

        private void dashboardBtn_Leave(object sender, EventArgs e)
        {
            dashboardBtn.BackColor = Color.FromArgb(35, 7, 94);
        }

        private void aboutBtn_Leave(object sender, EventArgs e)
        {
            aboutBtn.BackColor = Color.FromArgb(35, 7, 94);
        }

        private void contactBtn_Leave(object sender, EventArgs e)
        {
            contactBtn.BackColor = Color.FromArgb(35, 7, 94);
        }
    }
}
