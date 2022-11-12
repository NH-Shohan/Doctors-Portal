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
    public partial class userDashboard : Form
    {
        private DataAccess Da { get; set; }
        private DataSet dsObj { get; set; }

        public userDashboard()
        {
            InitializeComponent();
            Da = new DataAccess();
        }
        
        public userDashboard(DataSet dsObj)
        {
            InitializeComponent();
            this.dsObj = dsObj;
            //showEmail.Text = dsObj.Tables[0].Rows[0]["email"].ToString();
            //showName.Text = dsObj.Tables[0].Rows[0]["name"].ToString();
        }


        private void userDashboard_Load(object sender, EventArgs e)
        {
            pnlNav.Height = dashboardBtn.Height;
            pnlNav.Top = dashboardBtn.Top;
            pnlNav.Left = dashboardBtn.Left;
            dashboardBtn.BackColor = Color.FromArgb(75, 27, 151);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            //this.Close();
            UserHome userHomeObj = new UserHome(dsObj);
            userHomeObj.Show();
            Hide();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
