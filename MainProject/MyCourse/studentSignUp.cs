using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using Entities;

namespace PresentationLayer
{
    public partial class studentSignUp : Form
    {
        Information StudentSign = new Information();
        SignUpService StudentSignService = new SignUpService();

        public studentSignUp()
        {
            InitializeComponent();
        }

        private void closeimagebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            signUpSelect signUpSelect = new signUpSelect();
            signUpSelect.Show();
            this.Hide();

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text != "" && idBox.Text != "" && passwordBox.Text != "" && confirmPassBox.Text != "")
            {
                if (passwordBox.Text == confirmPassBox.Text)
                {
                    StudentSign.Name = nameBox.Text;
                    StudentSign.Id = idBox.Text;
                    StudentSign.Password = passwordBox.Text;

                    StudentSignService.InsetStudentLoginData(StudentSign);
                    MessageBox.Show("Successfully Registered");
                }
                else
                    MessageBox.Show("Password Do Not Match!");
            }
            else
                MessageBox.Show("Can not be empty");
           

        }
        private void Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginPage l = new loginPage();
            l.Show();
        }

    }
        
}
