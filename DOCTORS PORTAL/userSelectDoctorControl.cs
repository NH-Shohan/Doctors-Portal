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
    public partial class userSelectDoctorControl : UserControl
    {

        private DataAccess Da { get; set; }
        private Panel mainPanel1;
        private string city;
        private string extraQueryForChamber ="";
        string chamberName = "";
        string selCategory = "";
        int lowerLimit;
        int upperLimit;
        int totalDoctors;
        int pageCount;
        int maxCount = 4;
        private string chamberEmail;

        public userSelectDoctorControl()
        {
            InitializeComponent();
            getSQLInformation(extraQueryForChamber, chamberName);



        }

        public userSelectDoctorControl(Panel mainPanel1, string city)
        {
            InitializeComponent();

            this.mainPanel1 = mainPanel1;
            this.city = city;

            getSQLInformation(extraQueryForChamber, chamberName);
            getAllChamberInformation();

        }

        public void getSQLInformation(string chamberEmail, string chamberName)
        {
            this.chamberName = chamberName;
            labelCham.Text = chamberName;
            try
            {
                Da = new DataAccess();

                // Check for chamber selection
                if (chamberEmail != "")
                {
                    this.chamberEmail = chamberEmail;
                    extraQueryForChamber = " and ChamberEmail='" + chamberEmail + "'";
                    
                }
                else
                {
                    extraQueryForChamber = "";
                }

                // Check Category
                if(filterBox.Text == "ALL")
                {
                    selCategory = "";
                } else
                {
                    selCategory = " and Category='" + filterBox.Text + "'";

                }

                // SQL for doctors count
                string sql = "SELECT COUNT(*) as countDoctors FROM [DoctorsPortal].[dbo].[doctors] where city='" + city + "'  " + extraQueryForChamber + " " + selCategory + "";
                //MessageBox.Show(sql);
                DataSet ds = Da.ExecuteQuery(sql);
                doctorsCount.Text = ds.Tables[0].Rows[0]["countDoctors"].ToString();
                totalDoctors = Int32.Parse(doctorsCount.Text);
                lowerLimit = 0;
                upperLimit = maxCount;
                pageCount = 1;

                // 
                

                // SQL for getting all doctors
                getAllDoctorInformation();
                getAllChamberInformation();


            } catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void getAllDoctorInformation()
        {
            

            string sqlForShowDocs = "SELECT [Name], [Email], [City], [Category], [ImageLink] FROM [DoctorsPortal].[dbo].[doctors] where city='" + city + "' " + extraQueryForChamber + " " + selCategory + " order by id";
            DataSet dsForShowDocs = Da.ExecuteQuery(sqlForShowDocs);
            /*MessageBox.Show(dsForShowDocs.Tables[0].Rows[1]["Name"].ToString());*/

            showDoctorPanel.Controls.Clear();

            if (totalDoctors - lowerLimit == 0)
            {
                MessageBox.Show("There are no doctor at "+ chamberName + ".");
                //getSQLInformation("", "");
            } else
            {
                showDoctor[] showDoctorObj = new showDoctor[totalDoctors];

                // by pagination


                // next prev color
                //next
                //MessageBox.Show(dsForShowDocs.Tables[0].Rows[0]["ImageLink"].ToString());
                if ((pageCount * maxCount) >= totalDoctors)
                {
                    NextDocBtn.BaseColor = Color.FromArgb(151, 143, 255);
                    for (int i = lowerLimit; i < totalDoctors; i++)
                    {
                        showDoctorObj[i] = new showDoctor(dsForShowDocs.Tables[0].Rows[i]["ImageLink"].ToString());
                        showDoctorObj[i].DocName.Text = dsForShowDocs.Tables[0].Rows[i]["Name"].ToString();
                        showDoctorObj[i].CatName.Text = dsForShowDocs.Tables[0].Rows[i]["Category"].ToString();
                        //showDoctorObj[i].ImageLink = dsForShowDocs.Tables[0].Rows[i]["ImageLink"].ToString();

                        showDoctorPanel.Controls.Add(showDoctorObj[i]);
                    }
                }
                else
                {
                    NextDocBtn.BaseColor = Color.FromArgb(55, 17, 123);
                    for (int i = lowerLimit; i < upperLimit; i++)
                    {
                        showDoctorObj[i] = new showDoctor(dsForShowDocs.Tables[0].Rows[i]["ImageLink"].ToString());
                        showDoctorObj[i].DocName.Text = dsForShowDocs.Tables[0].Rows[i]["Name"].ToString();
                        showDoctorObj[i].CatName.Text = dsForShowDocs.Tables[0].Rows[i]["Category"].ToString();
                       // showDoctorObj[i].ImageLink = dsForShowDocs.Tables[0].Rows[i]["ImageLink"].ToString();



                        showDoctorPanel.Controls.Add(showDoctorObj[i]);
                    }

                }
            }

            //prev
            if (pageCount == 1)
            {
                PreviousDocBtn.BaseColor = Color.FromArgb(151, 143, 255);
            }
            else
            {
                PreviousDocBtn.BaseColor = Color.FromArgb(55, 17, 123);

            }

        }

        // next click
        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            if ((pageCount * maxCount) < totalDoctors)
            {
                upperLimit += maxCount;
                lowerLimit += maxCount;
                pageCount++;
                getAllDoctorInformation();
            }
        }
        // previous click
        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            if(pageCount != 1)
            {
                upperLimit -= maxCount;
                lowerLimit -= maxCount;
                pageCount--;
                getAllDoctorInformation();
            }
        }

        public void getAllChamberInformation()
        {
            string sqlForShowChams = "SELECT [Name], [Email], [City] FROM [DoctorsPortal].[dbo].[chambers] where city='" + city + "' order by id";
            DataSet dsForShowChams = Da.ExecuteQuery(sqlForShowChams);
            /*MessageBox.Show(dsForShowDocs.Tables[0].Rows[1]["Name"].ToString());*/

            showAllChams.Controls.Clear();
            showAllChambersControl[] showChamberObj = new showAllChambersControl[dsForShowChams.Tables[0].Rows.Count];

            for (int i = 0; i < dsForShowChams.Tables[0].Rows.Count; i++)
            {

                showChamberObj[i] = new showAllChambersControl(this, dsForShowChams.Tables[0].Rows[i]["Email"].ToString());
                showChamberObj[i].ChamName.Text = dsForShowChams.Tables[0].Rows[i]["Name"].ToString();
                showAllChams.Controls.Add(showChamberObj[i]);
            }

        }

        private void showAllDocBtn_Click(object sender, EventArgs e)
        {
            getSQLInformation("", "");
        }

        private void filterBox_TextChanged(object sender, EventArgs e)
        {
            getSQLInformation(chamberEmail, chamberName);

            selCategory = filterBox.Text;
        }
    }
}
