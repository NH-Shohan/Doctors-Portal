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
    public partial class userDashboardControl : UserControl
    {
        private Panel mainPanel1;

        public userDashboardControl()
        {
            InitializeComponent();
        }

        public userDashboardControl(Panel mainPanel1)
        {
            InitializeComponent();

            this.mainPanel1 = mainPanel1;
        }
    }
}
