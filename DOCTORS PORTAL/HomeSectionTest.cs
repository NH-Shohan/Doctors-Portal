using Guna.UI.WinForms;
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
    public partial class HomeSectionTest : UserControl
    {
        private Panel mainPanel;

        public HomeSectionTest()
        {
            InitializeComponent();
        }

        public HomeSectionTest(Panel mainPanel)
        {
            InitializeComponent();

            this.mainPanel = mainPanel;
        }

        private void dhakaBtn_Click(object sender, EventArgs e)
        {
            UserHome userHomeObj = new UserHome();

            // navigation
            userSelectDoctorControl userSelectDoctorControlObj = new userSelectDoctorControl(mainPanel, "Dhaka");
            mainPanel.Controls.Add(userSelectDoctorControlObj);
            mainPanel.Controls.Remove(this);
            Hide();

            userSelectDoctorControlObj.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            UserHome userHomeObj = new UserHome();

            // navigation
            userSelectDoctorControl userSelectDoctorControlObj = new userSelectDoctorControl(mainPanel, "Chittagong");
            mainPanel.Controls.Add(userSelectDoctorControlObj);
            mainPanel.Controls.Remove(this);
            Hide();

            userSelectDoctorControlObj.Show();
        }
    }
}
