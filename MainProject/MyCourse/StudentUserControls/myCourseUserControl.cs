using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using Entities;

namespace MyCourse
{
    public partial class myCourseUserControl : UserControl
    {
        StudentRegisteredCourseInfo studentRegisteredCourseInfo = new StudentRegisteredCourseInfo();
        StudentRegisteredCourseService studentRegisteredCourseService = new StudentRegisteredCourseService();

        public myCourseUserControl()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            courseNameBox.Visible = true; ;
            courseBox.Visible = true;
            dropButton.Visible = true;
            label3.Visible = true;
            sectionBox.Visible=true;
        }

        private void myCourseUserControl_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            studentRegisteredCourseInfo.StudentId = LoginHelper.UserId;
            studentRegisteredCourseInfo.StudentName = LoginHelper.UserName;
            dataTable=studentRegisteredCourseService.GetAllCourse(studentRegisteredCourseInfo);
            courseGrid.DataSource = dataTable;
        }

        private void dropButton_Click(object sender, EventArgs e)
        {

            if (courseBox.Text != "" && sectionBox.Text != "")
            {
                studentRegisteredCourseInfo.CourseName = courseBox.Text;
                studentRegisteredCourseInfo.CourseSection = sectionBox.Text;

                studentRegisteredCourseService.DropCourse(studentRegisteredCourseInfo);

                DataTable dataTable1 = new DataTable();
                //studentRegisteredCourseInfo.StudentId = LoginHelper.UserId;
                dataTable1 = studentRegisteredCourseService.GetAllCourse(studentRegisteredCourseInfo);
                courseGrid.DataSource = dataTable1;

                courseBox.Text = "";
                sectionBox.Text = "";
            }
            else
                MessageBox.Show("Can not be empty");
           
        }

        private void courseGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.courseGrid.Rows[e.RowIndex];

                courseBox.Text = row.Cells[0].Value.ToString();
                sectionBox.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
