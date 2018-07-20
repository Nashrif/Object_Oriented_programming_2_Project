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
    public partial class facultyListUserControl : UserControl
    {
        FacultyListInfo facultyListInfo = new FacultyListInfo();
        FacultyListService facultyListService = new FacultyListService();

        DataTable dataTable;

        public facultyListUserControl()
        {
            InitializeComponent();
        }

        public void DataGrid()
        {
            dataTable = new DataTable();
            dataTable = facultyListService.GetAllFacultyList();
            facultyListGrid.DataSource = dataTable;
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void facultyListUserControl_Load(object sender, EventArgs e)
        {
            DataGrid();
        }

        private void facultyListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.facultyListGrid.Rows[e.RowIndex];

                facultyIdBox.Text = row.Cells[1].Value.ToString();
            }
        }

        private void searchIdBox_OnValueChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dataTable);
            dv.RowFilter = string.Format("FacultyName LIKE '%{0}%'", searchIdBox.Text);
            facultyListGrid.DataSource = dv;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (facultyIdBox.Text != "")
            {
                DialogResult res = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);
                if (res.Equals(DialogResult.Yes))
                {
                    facultyListInfo.FacultyId = facultyIdBox.Text;
                    facultyListService.DeleteFaculty(facultyListInfo);
                    MessageBox.Show("Deleted..", "Message:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    facultyListGrid.DataSource = null;
                    facultyListGrid.DataSource = facultyListService.GetAllFacultyList();


                    facultyIdBox.Text = "";
                }
                else
                {
                    facultyListGrid.DataSource = null;
                    facultyListGrid.DataSource = facultyListService.GetAllFacultyList();
                }
            }
            else
                MessageBox.Show("Can not be empty");

           
        }
    }
}
