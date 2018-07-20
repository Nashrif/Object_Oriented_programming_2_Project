using PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCourse
{
    public partial class adminUi : Form
    {
        public adminUi()
        {
            InitializeComponent();
            sidePanel.Height = createCourseButton.Height;
            topLabel.Text = createCourseButton.Text;
        }

        private void createCourseButton_Click_1(object sender, EventArgs e)
        {
            sidePanel.Height = createCourseButton.Height;
            sidePanel.Top = createCourseButton.Top;
            topLabel.Text = createCourseButton.Text;

            createCourseUserControl1.Visible = true;
            createCourseUserControl1.BringToFront();
        }

        private void courseListBtn_Click_1(object sender, EventArgs e)
        {
            sidePanel.Height = courseListBtn.Height;
            sidePanel.Top = courseListBtn.Top;
            topLabel.Text = courseListBtn.Text;

            courseListUserControl1.Visible = true;
            courseListUserControl1.BringToFront();
        }

        private void facultyListBtn_Click_1(object sender, EventArgs e)
        {
            sidePanel.Height = facultyListBtn.Height;
            sidePanel.Top = facultyListBtn.Top;
            topLabel.Text = facultyListBtn.Text;

            facultyListUserControl1.Visible = true;
            facultyListUserControl1.BringToFront();
        }

        private void studentListBtn_Click_1(object sender, EventArgs e)
        {
            sidePanel.Height = studentListBtn.Height;
            sidePanel.Top = studentListBtn.Top;
            topLabel.Text = studentListBtn.Text;

            studentListUserControl1.Visible = true;
            studentListUserControl1.BringToFront();
        }

        private void assignFacultyBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = assignFacultyBtn.Height;
            sidePanel.Top = assignFacultyBtn.Top;
            topLabel.Text = assignFacultyBtn.Text;

            assignFacultyUserControl1.Visible = true;
            assignFacultyUserControl1.BringToFront();
        }

        private void examTimeBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = examTimeBtn.Height;
            sidePanel.Top = examTimeBtn.Top;
            topLabel.Text = examTimeBtn.Text;

            setExamTimeUserControl1.Visible = true;
            setExamTimeUserControl1.BringToFront();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOut_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);
            if (res.Equals(DialogResult.Yes))
            {
                loginPage loginPage = new loginPage();
                loginPage.Show();
                this.Hide();
            }
            else
            { }
        }
    }
}
