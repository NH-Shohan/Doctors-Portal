using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOCTORS_PORTAL
{
    public partial class loginForm : Form
    {

        private DataAccess Da { get; set; }
        public loginForm()
        {
            InitializeComponent();
            rightEmail.Text = "";
            Da = new DataAccess();

            // To show star
            //passLogin.PasswordChar = '●';
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

        private void goRegistrationFormBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            registrationForm registrationForm = new registrationForm();
            registrationForm.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (!this.isValidToLogin())
            {
                MessageBox.Show("Please fill the informations");
                return;
            }

            try
            {
                string sql = "SELECT * FROM [DoctorsPortal].[dbo].[user] where Email='" + emailLogin.Text + "' AND password='" + passLogin.Text + "'";
                DataSet ds = Da.ExecuteQuery(sql);

                //MessageBox.Show(ds.Tables[0].Rows[0]["id"].ToString());

                if(ds.Tables[0].Rows[0]["email"].ToString() == emailLogin.Text || ds.Tables[0].Rows[0]["password"].ToString() == passLogin.Text)
                {
                    UserHome userHomeObj = new UserHome(ds);
                    userDashboard userDashboardObj = new userDashboard(ds);

                    userHomeObj.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("No user exist");
                }


                
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }

            /*this.Hide();
            UserHome userHome = new UserHome();
            userHome.Show();*/
        }

        bool isValidToLogin()
        {
            if (String.IsNullOrEmpty(emailLogin.Text) || String.IsNullOrWhiteSpace(passLogin.Text))
            {
                return false;
            }
            return true;
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (!Regex.IsMatch(emailLogin.Text, pattern) || emailLogin.Text == "")
            {
                rightEmail.Text = "❌";
            } else
            {
                rightEmail.Text = "✔️";
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            hide.Show();
            show.Hide();
            passLogin.PasswordChar = '\0';
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            hide.Hide();
            show.Show();
            passLogin.PasswordChar = '●';
        }

        private void emailLogin_Enter(object sender, EventArgs e)
        {
            if (emailLogin.Text == "someone@example.com")
            {
                emailLogin.Text = "";
                emailLogin.ForeColor = Color.Black;
            }
        }

        private void emailLogin_Leave(object sender, EventArgs e)
        {
            if (emailLogin.Text == "")
            {
                emailLogin.Text = "someone@example.com";
                emailLogin.ForeColor = Color.LightGray;
                rightEmail.Text = "❌";
            }
        }

        private void rightEmail_Click(object sender, EventArgs e)
        {
            if (rightEmail.Text == "❌")
            {
                emailLogin.Text = "";
            }
        }

        private void passLogin_Enter(object sender, EventArgs e)
        {
            if (passLogin.Text == "Enter Password")
            {
                passLogin.Text = "";
                passLogin.PasswordChar = '●';
                passLogin.ForeColor = Color.Black;
            }
        }

        private void passLogin_Leave(object sender, EventArgs e)
        {
            if (passLogin.Text == "")
            {
                passLogin.Text = "Enter Password";
                passLogin.ForeColor = Color.LightGray;
            }
        }
    }
}
