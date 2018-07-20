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

namespace MyCourse.AdminUserControls
{

    public partial class courseListUserControl : UserControl
    {
        CourseListInfo courseListInfo = new CourseListInfo();
        CourseListService courseListService = new CourseListService();

        DataTable dataTable;

        public courseListUserControl()
        {
            InitializeComponent();
        }

        private void courseListUserControl_Load(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            dataTable = courseListService.GetAllCourse();
            courseListGrid.DataSource = dataTable;

        }

        private void courseListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.courseListGrid.Rows[e.RowIndex];

                courseIdBox.Text = row.Cells[1].Value.ToString();
                sectionBox.Text = row.Cells[2].Value.ToString();
                sectionBox1.Text = row.Cells[3].Value.ToString();
                sectionBox2.Text = row.Cells[4].Value.ToString();
                courseNameBox.Text = row.Cells[0].Value.ToString();
            }
        }

        private void searchIdBox_OnValueChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dataTable);
            dv.RowFilter = string.Format("CourseName LIKE '%{0}%'", searchIdBox.Text);
            courseListGrid.DataSource = dv;
        }

        void clear()
        {
            courseIdBox.Text = "";
        }


        private void completeBtn_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);
            if (res.Equals(DialogResult.Yes))
            {
                courseListInfo.CourseId = Convert.ToInt32(courseIdBox.Text);
                courseListInfo.Section1 = sectionBox.Text;
                courseListInfo.Section2 = sectionBox1.Text;
                courseListInfo.Section3 = sectionBox2.Text;
                courseListInfo.CourseName = courseNameBox.Text;

                if(sectionBox.Text!="" && sectionBox1.Text=="" && sectionBox2.Text=="")
                {
                    courseListService.DeleteCourse1(courseListInfo);
                }
                if (sectionBox.Text != "" && sectionBox1.Text != "" && sectionBox2.Text == "")
                {
                    courseListService.DeleteCourse2(courseListInfo);
                }
                if (sectionBox.Text != "" && sectionBox1.Text != "" && sectionBox2.Text != "")
                {
                    courseListService.DeleteCourse3(courseListInfo);
                }
                courseListService.DeleteCourse(courseListInfo);
                MessageBox.Show("Deleted..", "Message:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                courseListGrid.DataSource = null;
                courseListGrid.DataSource = courseListService.GetAllCourse();
            }
            else
            {
                courseListGrid.DataSource = null;
                courseListGrid.DataSource = courseListService.GetAllCourse();
            }
        }
    }
}
