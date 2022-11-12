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
    public partial class showAllChambersControl : UserControl
    {
        private userSelectDoctorControl userSelectDoctorControl;
        private string chamberEmail;

        public Label ChamName
        {
            get { return nameOfChamber; }
            set { }
        }
        public showAllChambersControl()
        {
            InitializeComponent();
        }

        public showAllChambersControl(userSelectDoctorControl userSelectDoctorControl, string chamberEmail)
        {
            InitializeComponent();

            this.userSelectDoctorControl = userSelectDoctorControl;
            this.chamberEmail = chamberEmail;
        }

        public void nameOfChamber_Click(object sender, EventArgs e)
        {

            userSelectDoctorControl.getSQLInformation(chamberEmail, ChamName.Text);
        }
    }
}
