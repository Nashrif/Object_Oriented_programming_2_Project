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
    public partial class noticeUserControl : UserControl
    {
        StudentNoticeInfo studentNoticeInfo = new StudentNoticeInfo();
        StudentNoticeService studentNoticeService = new StudentNoticeService();


        public noticeUserControl()
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
                studentNoticeInfo.CourseName = courseNameBox.Text;
                studentNoticeInfo.CourseSection = sectionNameBox.Text;

                DataTable dataTable1 = new DataTable();
                dataTable1 = studentNoticeService.GetNoticeSubject(studentNoticeInfo);
                noticeSubjectGrid.DataSource = dataTable1;
            }
            else
                MessageBox.Show("can not be empty");
            //noticeSubjectGrid.Columns[1].Visible = false;
        }


        private void openBtn_Click(object sender, EventArgs e)
        {
            if (subjectBox.Text != "")
            {
                noticeGrid.Visible = true;
                studentNoticeInfo.NoticeSubject = subjectBox.Text;
                DataTable dataTable = new DataTable();
                dataTable = studentNoticeService.GetNotice(studentNoticeInfo);
                noticeGrid.DataSource = dataTable;
            }
            else
                MessageBox.Show("can not be empty");
                

        }

        private void noticeUserControl_Load(object sender, EventArgs e)
        {
            studentNoticeInfo.StudentId = LoginHelper.UserId;
            DataTable dataTable = new DataTable();
            dataTable = studentNoticeService.GetCourse(studentNoticeInfo);
            courseGrid.DataSource = dataTable;


        }

        private void noticeSubjectGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.noticeSubjectGrid.Rows[e.RowIndex];


                subjectBox.Text = row.Cells[0].Value.ToString();
                //sectionNameBox.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
