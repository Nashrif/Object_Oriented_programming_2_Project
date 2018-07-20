using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class signUpSelect : Form
    {
        public signUpSelect()
        {
            InitializeComponent();
        }

        private void facultyButton_Click(object sender, EventArgs e)
        {
            facultySignUp facultySignUp = new facultySignUp();
            facultySignUp.Show();
            this.Hide();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            studentSignUp studentSignUp = new studentSignUp();
            studentSignUp.Show();
            this.Hide();
        }

        private void closeimagebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            loginPage loginPage = new loginPage();
            loginPage.Show();
            this.Hide();
        }
    }
}
