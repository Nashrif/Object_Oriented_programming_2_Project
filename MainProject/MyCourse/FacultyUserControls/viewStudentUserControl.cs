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

namespace MyCourse
{
    public partial class viewStudentUserControl : UserControl
    {
        ViewStudentAsFacultyInfo viewStudentAsFacultyInfo = new ViewStudentAsFacultyInfo();
        ViewStudentAsFacultyService viewStudentAsFacultyService = new ViewStudentAsFacultyService();

        DataTable dataTable, dataTable1;

        public viewStudentUserControl()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            removeStudentPanel.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //viewStudentAsFacultyInfo.CourseName = courseNameBox.Text;
            //viewStudentAsFacultyInfo.CourseSection = sectionNameBox.Text;
            viewStudentAsFacultyInfo.FacultyId = LoginHelper.UserId;

            dataTable = new DataTable();
            dataTable = viewStudentAsFacultyService.GetAllourse(viewStudentAsFacultyInfo);
            courseGrid.DataSource = dataTable;
        }

        private void courseGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.courseGrid.Rows[e.RowIndex];

                courseNameBox.Text = row.Cells[0].Value.ToString();
                sectionNameBox.Text = row.Cells[1].Value.ToString();
            }
        }

        private void viewStudentUserControl_Load(object sender, EventArgs e)
        {
           
        }

        private void studentListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.studentListGrid.Rows[e.RowIndex];

                StudentNameBox.Text = row.Cells[0].Value.ToString();
                StudentIdBox.Text = row.Cells[1].Value.ToString();
            }
        }

        private void searchBox_OnValueChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dataTable1);
            dv.RowFilter = string.Format("StudentList LIKE '%{0}%'", searchBox.Text);
            studentListGrid.DataSource = dv;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if(StudentNameBox.Text!="" && StudentIdBox.Text!="")
            {
                viewStudentAsFacultyInfo.StudentName = StudentNameBox.Text;
                viewStudentAsFacultyInfo.StudentId = StudentIdBox.Text;

                viewStudentAsFacultyService.RemoveStudent(viewStudentAsFacultyInfo);
            }
        }

        private void selectBtn_Click_1(object sender, EventArgs e)
        {
            if (courseNameBox.Text != "" && sectionNameBox.Text != "")
            {
                viewStudentAsFacultyInfo.CourseName = courseNameBox.Text;
                viewStudentAsFacultyInfo.CourseSection = sectionNameBox.Text;

                dataTable1 = new DataTable();
                dataTable1 = viewStudentAsFacultyService.GetAllStudent(viewStudentAsFacultyInfo);
                studentListGrid.DataSource = dataTable1;
            }
            else
                MessageBox.Show("can not be empty");
        }
    }
}
