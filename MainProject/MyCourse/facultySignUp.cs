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
using Services;

namespace PresentationLayer
{
    public partial class facultySignUp : Form
    {
        Information SignUp = new Information();
        SignUpService SignUpService = new SignUpService();

        public facultySignUp()
        {
            InitializeComponent();
        }

        public void clear()
        {
            nameBox.Text = idBox.Text = passwordBox.Text = confirmPassBox.Text = "";
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text != "" && idBox.Text != "" && passwordBox.Text != "" && confirmPassBox.Text != "")
            {
                if (passwordBox.Text == confirmPassBox.Text)
                {

                    SignUp.Name = nameBox.Text;
                    SignUp.Id = idBox.Text;
                    SignUp.Password = passwordBox.Text;

                    SignUpService.InsetFacultyLoginData(SignUp);
                    MessageBox.Show("Successfully Registered");
                    clear();
                }
                else
                    MessageBox.Show("Password Do Not Match!");
            }
            else
                MessageBox.Show("Can not be empty");
           
        }

        private void loginPage_Click(object sender, EventArgs e)
        {
            loginPage l = new loginPage();
            this.Hide();
            l.Show();

        }

        private void facultySignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
