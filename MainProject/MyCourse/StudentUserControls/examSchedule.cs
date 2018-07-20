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
    public partial class examScheduleUserControl : UserControl
    {
        ExamScheduleInfo examScheduleInfo = new ExamScheduleInfo();
        ExamScheduleService examScheduleService = new ExamScheduleService();

        public examScheduleUserControl()
        {
            InitializeComponent();
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

        private void selectBtn_Click(object sender, EventArgs e)
        {
            if (courseNameBox.Text != "" && sectionNameBox.Text != "")
            {
                examScheduleInfo.CourseName = courseNameBox.Text;
                examScheduleInfo.CourseSection = sectionNameBox.Text;

                DataTable dataTable = new DataTable();
                dataTable = examScheduleService.GetSchedule(examScheduleInfo);
                examGrid.DataSource = dataTable;
            }
            else
                MessageBox.Show("can not be empty");
           
        }

        private void examScheduleUserControl_Load(object sender, EventArgs e)
        {
            examScheduleInfo.StudentId = LoginHelper.UserId;
            DataTable dataTable = new DataTable();
            dataTable = examScheduleService.GetExam(examScheduleInfo);
            courseGrid.DataSource = dataTable;
        }
    }
}
