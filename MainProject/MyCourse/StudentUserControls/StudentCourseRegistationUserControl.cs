using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Services;

namespace MyCourse.StudentUserControls
{
    public partial class StudentCourseRegistationUserControl : UserControl
    {
        StudentCourseSelectInfo studentCourseSelectInfo = new StudentCourseSelectInfo();
        StudentCourseSelectService studentCourseSelectService = new StudentCourseSelectService();
        public string numberOfSection;

        public StudentCourseRegistationUserControl()
        {
            InitializeComponent();
        }

        DataTable dataTable, dataTable1;

     

        private void StudentCourseRegistationUserControl_Load(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            dataTable = studentCourseSelectService.GetAllCourse();
            CourseGrid.DataSource = dataTable;
        }

        private void firstSectionBtn_Click(object sender, EventArgs e)
        {

            if (CourseBox.Text != "")
            {
                SectionBox.Visible = true;

                dataTable1 = new DataTable();
                studentCourseSelectInfo.CourseName = CourseBox.Text;
                dataTable1 = studentCourseSelectService.GetAllSection(studentCourseSelectInfo);
                SectionGrid.DataSource = dataTable1;

            }
            else
                MessageBox.Show("Can not be empty");

        }


        private void CourseGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.CourseGrid.Rows[e.RowIndex];

                
                CourseBox.Text = row.Cells[0].Value.ToString();
            }
        }

        private void SectionGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.SectionGrid.Rows[e.RowIndex];
                SectionBox.Text = row.Cells[0].Value.ToString();
               
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if(CourseBox.Text != "" && SectionBox.Text!="")
            {
                studentCourseSelectInfo.CourseName = CourseBox.Text;
                studentCourseSelectInfo.CourseSection = SectionBox.Text;
                studentCourseSelectInfo.StudentId = LoginHelper.UserId;
                studentCourseSelectInfo.StudentName = LoginHelper.UserName;

                studentCourseSelectService.InsertCourseToStudent(studentCourseSelectInfo);

                CourseBox.Text = "";
                SectionBox.Text = "";
            }
            else
                MessageBox.Show("Can not be empty");

        }

        private void searchIdBox_OnValueChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dataTable);
            dv.RowFilter = string.Format("CourseName LIKE '%{0}%'", searchIdBox.Text);
            CourseGrid.DataSource = dv;
        }
    }
}
