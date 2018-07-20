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
    public partial class courseProgressUserConrol : UserControl
    {
        StudentProgressInfo studentProgressInfo = new StudentProgressInfo();
        StudentProgressService studentProgressService = new StudentProgressService();

        public courseProgressUserConrol()
        {
            InitializeComponent();

        }

        private void courseProgressUserConrol_Load(object sender, EventArgs e)
        {
            studentProgressInfo.StudentId = LoginHelper.UserId;
            DataTable dataTable = new DataTable();
            dataTable = studentProgressService.GetCourse(studentProgressInfo);
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

        private void selectBtn_Click(object sender, EventArgs e)
        {
            studentProgressInfo.CourseName = courseNameBox.Text;
            studentProgressInfo.CourseSection = sectionNameBox.Text;
            studentProgressInfo.Topic = topicBox.Text;

            if (studentProgressInfo.CourseName != "" && studentProgressInfo.CourseSection != "")
            {
                DataTable dataTable1 = new DataTable();
                dataTable1 = studentProgressService.GetTopic(studentProgressInfo);
                TopicGrid.DataSource = dataTable1;
                TopicGrid.Columns[1].Visible = false;
                panel1.Visible = true;
            }
            else
                MessageBox.Show("Can Not Be Empty");
            
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            if (progressBox.Text!= "")
            {
                progressBar.Value = Convert.ToInt32(progressBox.Text);
            }
            else
                MessageBox.Show("Can Not Be Empty");
        }

        private void TopicGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.TopicGrid.Rows[e.RowIndex];

                topicBox.Text = row.Cells[0].Value.ToString();
                progressBox.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
