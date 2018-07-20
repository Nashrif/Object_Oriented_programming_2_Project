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
    public partial class insertCourseProgressUserControl : UserControl
    {
        InsertCourseProgressInfo insertCourseProgressInfo = new InsertCourseProgressInfo();
        InsertCourseProgressService insertCourseProgressService = new InsertCourseProgressService();

        public insertCourseProgressUserControl()
        {
            InitializeComponent();
        }

        private void percentageBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            insertCourseProgressInfo.FacultyId = LoginHelper.UserId;
            DataTable dataTable = new DataTable();
            dataTable = insertCourseProgressService.GetAllCourse(insertCourseProgressInfo);
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

        private void outlineGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.outlineGrid.Rows[e.RowIndex];

                outlineBox.Text = row.Cells[0].Value.ToString();
                //sectionNameBox.Text = row.Cells[1].Value.ToString();
            }
        }

        private void completeBtn_Click(object sender, EventArgs e)
        {
            if (outlineBox.Text != "" && percentageBox.Text != "")
            {
                insertCourseProgressInfo.Outline = outlineBox.Text;
                insertCourseProgressInfo.Percentage = percentageBox.Text;

                insertCourseProgressService.InsertPercentage(insertCourseProgressInfo);


                DataTable dataTable1 = new DataTable();
                dataTable1 = insertCourseProgressService.GetAllOutline(insertCourseProgressInfo);
                outlineGrid.DataSource = dataTable1;
            }
            else
                MessageBox.Show("can not be empty");

      
        }

        private void selectBtn_Click_1(object sender, EventArgs e)
        {
            if (courseNameBox.Text != "" && sectionNameBox.Text != "")
            {
                insertCourseProgressInfo.CourseName = courseNameBox.Text;
                insertCourseProgressInfo.Section = sectionNameBox.Text;

                DataTable dataTable1 = new DataTable();
                dataTable1 = insertCourseProgressService.GetAllOutline(insertCourseProgressInfo);
                outlineGrid.DataSource = dataTable1;
            }
            else
                MessageBox.Show("can not be empty");
           
        }
    }
}
