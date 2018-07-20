using MyCourse.StudentUserControls;
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
    public partial class studentUi : Form
    {
        public studentUi()
        {
            InitializeComponent();
            sidePanel.Height = registationBtn.Height;
            topLabel.Text = registationBtn.Text;

        }

        
        private void studentUi_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

            private void courseButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = courseButton.Height;
            sidePanel.Top = courseButton.Top;
            topLabel.Text = courseButton.Text;

            myCourseUserControl1.Visible = true;
            myCourseUserControl1.BringToFront();
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = scheduleButton.Height;
            sidePanel.Top = scheduleButton.Top;
            topLabel.Text = scheduleButton.Text;


            myScheduleUserControl1.Visible = true;
            myScheduleUserControl1.BringToFront();
        }

        private void progressButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = progressButton.Height;
            sidePanel.Top = progressButton.Top;
            topLabel.Text = progressButton.Text;

            courseProgressUserConrol1.Visible = true;
            courseProgressUserConrol1.BringToFront();
        }

        private void noteButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = noteButton.Height;
            sidePanel.Top = noteButton.Top;
            topLabel.Text = noteButton.Text;

            noteUserControl1.Visible = true;
            noteUserControl1.BringToFront();
        }

        private void noticeButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = noticeButton.Height;
            sidePanel.Top = noticeButton.Top;
            topLabel.Text = noticeButton.Text;

            noticeUserControl1.Visible = true;
            noticeUserControl1.BringToFront();
        }

        private void examButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = examButton.Height;
            sidePanel.Top = examButton.Top;
            topLabel.Text = examButton.Text;

            examScheduleUserControl1.Visible = true;
            examScheduleUserControl1.BringToFront();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);
            if (res.Equals(DialogResult.Yes))
            {
                loginPage loginPage = new loginPage();
                loginPage.Show();
                this.Hide();
            }
        }

        private void registationBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = registationBtn.Height;
            sidePanel.Top = registationBtn.Top;
            topLabel.Text = registationBtn.Text;

            studentCourseRegistationUserControl1.Visible = true;
            studentCourseRegistationUserControl1.BringToFront();

        }

        private void studentCourseRegistationUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
