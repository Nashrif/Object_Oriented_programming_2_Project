using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using MyCourse;
using Services;


namespace PresentationLayer
{
    public partial class loginPage : Form
    {
        Information information = new Information();
        LoginService LoginService = new LoginService();

        DataTable dt = new DataTable();
        string userType;
        //public string userLoginid;

        public loginPage()
        {
            InitializeComponent();
        }

        private void closeimagebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //studentUi studentUi = new studentUi();
            //studentUi.Show();
            //this.Hide();
            information.Id = userIdBox.Text;
            information.Password = passwordBox.Text;
            if (userIdBox.Text != "" && passwordBox.Text != "")
            {
                dt = LoginService.GetLogin(information);
                userIdBox.Text = "";
                passwordBox.Text = "";
                if (dt.Rows.Count > 0)
                {

                    userType = dt.Rows[0][3].ToString().Trim();
                    //userLoginid = dt.Rows[0][1].ToString().Trim();
                    LoginHelper.UserId = dt.Rows[0][1].ToString().Trim();
                    LoginHelper.UserName = dt.Rows[0][0].ToString().Trim();

                    if (userType == "3")
                    {

                        studentUi studentUi = new studentUi();
                        studentUi.Show();
                        this.Hide();

                    }

                    else if (userType == "2")
                    {
                        facultyUi facultyUi = new facultyUi();
                        facultyUi.Show();

                        this.Hide();
                    }
                    else if (userType == "1")
                    {
                        adminUi adminUi = new adminUi();
                        adminUi.Show();

                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password !");
                }
            }
            else
                MessageBox.Show("Can Not Be Empty");
           


        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            signUpSelect signUpSelect = new signUpSelect();
            signUpSelect.Show();
            this.Hide();
        }
    }
}
