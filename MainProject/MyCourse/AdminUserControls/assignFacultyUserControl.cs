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

    public partial class assignFacultyUserControl : UserControl
    {
        AssignFacultyInfo assignFacultyInfo = new AssignFacultyInfo();
        AssignFacultyService assignFacultyService = new AssignFacultyService();
        DataTable dataTable,dataTable1;

        public assignFacultyUserControl()
        {
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (courseNameBox.Text != "" && sectionBox.Text != "" && facultyBox.Text != "" && facultyIdBox.Text != "")
            {

                assignFacultyInfo.CourseName = courseNameBox.Text;
                assignFacultyInfo.Section = sectionBox.Text;
                assignFacultyInfo.Faculty = facultyBox.Text;
                assignFacultyInfo.FacultyId = facultyIdBox.Text;

                assignFacultyService.AssignFaculty(assignFacultyInfo);
                clear();
            }
            else
                MessageBox.Show("Can not be empty");

        }
        public void clear()
        {
            courseNameBox.Text = "";
            sectionBox.Text ="";
            facultyBox.Text = "";
            facultyIdBox.Text = "";
        }

        private void facultyGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.facultyGrid.Rows[e.RowIndex];

                facultyBox.Text = row.Cells[0].Value.ToString();
                facultyIdBox.Text = row.Cells[1].Value.ToString();
            }

        }

        private void courseGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (courseGrid.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (courseGrid.CurrentCell != null && courseGrid.CurrentCell.Value != null)
                {
                    courseNameBox.Text = courseGrid.CurrentCell.Value.ToString();
                }
            }
            if (courseGrid.CurrentCell.ColumnIndex.Equals(2) && e.RowIndex != -1)
            {
                if (courseGrid.CurrentCell != null && courseGrid.CurrentCell.Value != null)
                {
                    sectionBox.Text = courseGrid.CurrentCell.Value.ToString();
                }
            }
            if (courseGrid.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                if (courseGrid.CurrentCell != null && courseGrid.CurrentCell.Value != null)
                {
                    sectionBox.Text = courseGrid.CurrentCell.Value.ToString();
                }
            }
            if (courseGrid.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                if (courseGrid.CurrentCell != null && courseGrid.CurrentCell.Value != null)
                {
                    sectionBox.Text = courseGrid.CurrentCell.Value.ToString();
                }
            }
        }

        private void searchFacultyBox_OnValueChanged(object sender, EventArgs e)
        {
            DataView dataView = new DataView(dataTable);
            dataView.RowFilter = string.Format("FacultyName LIKE '%{0}%'", searchFacultyBox.Text);
            facultyGrid.DataSource = dataView;
        }

        private void searchCourseBox_OnValueChanged(object sender, EventArgs e)
        {
            DataView dataView = new DataView(dataTable1);
            dataView.RowFilter = string.Format("CourseName LIKE '%{0}%'", searchCourseBox.Text);
            courseGrid.DataSource = dataView;
        }

        private void assignFacultyUserControl_Load(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            dataTable = assignFacultyService.GetAllFaculty();
            facultyGrid.DataSource = dataTable;

            dataTable1 = new DataTable();
            dataTable1 = assignFacultyService.GetAllcourse();
            courseGrid.DataSource = dataTable1;
        }
    }
}
