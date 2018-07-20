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
using Entities;

namespace MyCourse
{
    public partial class facultyUi : Form
    {
        //UserIdInfo userIdInfo = new UserIdInfo();
        //public static string facultyUserId;

        public facultyUi()
        {
            InitializeComponent();
            sidePanel.Height = assignedCourseButton.Height;
            topLabel.Text = assignedCourseButton.Text;
            //this.facultyUserId = facultyUserId;
            //userIdLabel.Text = facultyUserId;
           // facultyUserId = userId;
        }

        private void studentUi_Load(object sender, EventArgs e)
        {
            //userIdInfo.UserId = facultyUserId;
         //   userIdLabel.Text = LoginHelper.UserName;
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void assignedCourseButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = assignedCourseButton.Height;
            sidePanel.Top = assignedCourseButton.Top;
            topLabel.Text = assignedCourseButton.Text;

            myAssignedCourseUserControl1.Visible = true;
            myAssignedCourseUserControl1.BringToFront();
        }

        private void addOutlineButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = addOutlineButton.Height;
            sidePanel.Top = addOutlineButton.Top;
            topLabel.Text = addOutlineButton.Text;

            addCourseOutlineUserControl1.Visible = true;
            addCourseOutlineUserControl1.BringToFront();
        }

        private void viewStudentButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = viewStudentButton.Height;
            sidePanel.Top = viewStudentButton.Top;
            topLabel.Text = viewStudentButton.Text;

            viewStudentUserControl1.Visible = true;
            viewStudentUserControl1.BringToFront();
        }

        private void insertProgressButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = insertProgressButton.Height;
            sidePanel.Top = insertProgressButton.Top;
            topLabel.Text = insertProgressButton.Text;

            insertCourseProgressUserControl1.Visible = true;
            insertCourseProgressUserControl1.BringToFront();
        }

        private void insertNotesButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = insertNotesButton.Height;
            sidePanel.Top = insertNotesButton.Top;
            topLabel.Text = insertNotesButton.Text;

            insertNoteUserControl1.Visible = true;
            insertNoteUserControl1.BringToFront();
        }

 
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void logOut_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);
            if (res.Equals(DialogResult.Yes))
            {
                loginPage login = new loginPage();
                login.Show();
                this.Hide();
            }
        }

        private void postNoticeButton_Click_1(object sender, EventArgs e)
        {
            sidePanel.Height = postNoticeButton.Height;
            sidePanel.Top = postNoticeButton.Top;
            topLabel.Text = postNoticeButton.Text;

            insertNoticeUserControl1.Visible = true;
            insertNoticeUserControl1.BringToFront();
        }
    }
}
