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
    public partial class addCourseOutlineUserControl : UserControl
    {
        AddCourseOutlineInfo courseOutlineInfo = new AddCourseOutlineInfo();
        AddCourseOutlineService addCourseOutlineService = new AddCourseOutlineService();

        public addCourseOutlineUserControl()
        {
            InitializeComponent();
        }


        private void registeredCourseGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.registeredCourseGrid.Rows[e.RowIndex];
                courseNameBox.Text = row.Cells[0].Value.ToString();
                sectionBox.Text = row.Cells[1].Value.ToString();
            }
                
        }

        private void firstOutlineBtn_Click(object sender, EventArgs e)
        {
            if (outlineBox.Text != "")
            {
                courseOutlineInfo.CourseName = courseNameBox.Text;
                courseOutlineInfo.Section = sectionBox.Text;
                courseOutlineInfo.Outline = outlineBox.Text;

                addCourseOutlineService.InsertOutline(courseOutlineInfo);
                DataTable dataTable2 = new DataTable();
                dataTable2 = addCourseOutlineService.GetAllCourseOutline(courseOutlineInfo);
                outlineGrid.DataSource = dataTable2;
            }
            else
                MessageBox.Show("can not be empty");
           
        }

        private void addCourseOutlineUserControl_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            //courseOutlineEntities.CourseName = courseNameBox.Text;
            //courseOutlineEntities.Section = SectionBox.Text;
            courseOutlineInfo.FacultyId = LoginHelper.UserId;
            dataTable = addCourseOutlineService.GetAllRegisteredCourse(courseOutlineInfo);
            registeredCourseGrid.DataSource = dataTable;
        }

        private void Selectbutton_Click(object sender, EventArgs e)
        {
            if (courseNameBox.Text != "" && sectionBox.Text != "")
            {
                DataTable dataTable1 = new DataTable();
                //courseOutlineInfo.FacultyId1 = LoginHelper.UserId;
                courseOutlineInfo.CourseName = courseNameBox.Text;
                courseOutlineInfo.Section = sectionBox.Text;
                dataTable1 = addCourseOutlineService.GetAllCourseOutline(courseOutlineInfo);
                outlineGrid.DataSource = dataTable1;
            }
            else
                MessageBox.Show("can not be empty");
           
        }
    }
}
