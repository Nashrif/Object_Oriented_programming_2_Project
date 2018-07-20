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
    public partial class insertNoticeUserControl : UserControl
    {
        InsertNoticeInfo insertNoticeInfo = new InsertNoticeInfo();
        InsertNoticeService insertNoticeService = new InsertNoticeService();

        public insertNoticeUserControl()
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            insertNoticeInfo.FacultyId = LoginHelper.UserId;

            DataTable dataTable = new DataTable();
            dataTable = insertNoticeService.GetAllCourse(insertNoticeInfo);
            courseGrid.DataSource = dataTable;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (courseNameBox.Text != "" && sectionNameBox.Text != "" && subjectBox.Text != "" && noticeBox.Text != "")
            {
                insertNoticeInfo.CourseSubject = subjectBox.Text;
                insertNoticeInfo.CourseNotice = noticeBox.Text;
                insertNoticeInfo.CourseName = courseNameBox.Text;
                insertNoticeInfo.CourseSection = sectionNameBox.Text;

                insertNoticeService.InsertNotice(insertNoticeInfo);

                courseNameBox.Text = "";
                sectionNameBox.Text = "";
                subjectBox.Text = "";
                noticeBox.Text = "";
            }
            else
                MessageBox.Show("can not be empty");
          
        }
    }
}
