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
    public partial class showDoctor : UserControl
    {
       public string imageLink;

        public Label DocName
        {
            get { return nameOfDoctor; }
            set { }
        }
        public Label CatName
        {
            get { return catName; }
            set { }
        }

        /*public string ImageLink   // property
        {
            get { return imageLink; }   // get method
            set { imageLink = value; }  // set method
        }*/

        public showDoctor()
        {
            InitializeComponent();
            //MessageBox.Show(imageLink);
            GunaCirclePictureBox picture = new GunaCirclePictureBox
            {
                Name = "pictureBox",
                Size = new Size(55, 55),
                //Location = new Point(14, 17),
                Image = Image.FromFile(@imageLink),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            doctorImagePanel.Controls.Add(picture);
        }

        public showDoctor(string imageLink)
        {
            InitializeComponent();
            this.imageLink = imageLink; 
            //MessageBox.Show(imageLink);
            GunaCirclePictureBox picture = new GunaCirclePictureBox
            {
                Name = "pictureBox",
                Size = new Size(55, 55),
                //Location = new Point(14, 17),
                Image = Image.FromFile(@imageLink),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            doctorImagePanel.Controls.Add(picture);
        }
    }
}
