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
//using System.Data;

namespace MyCourse.AdminUserControls
{
    public partial class StudentUserControl : UserControl
    {
        StudentListInfo studentListInfo = new StudentListInfo();
        StudentListService studentListService = new StudentListService();

        DataTable dataTable;

        public StudentUserControl()
        {
            InitializeComponent();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        public void DataGrid()
        {
            dataTable = new DataTable();
            dataTable = studentListService.GetAllStudentList();
            studentListGrid.DataSource = dataTable;
        }

        private void studentListUserControl_Load(object sender, EventArgs e)
        {
            DataGrid();
        }

        private void studentListGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.studentListGrid.Rows[e.RowIndex];

                studentIdBox.Text = row.Cells[1].Value.ToString();
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (studentIdBox.Text != null)
            {
                DialogResult res = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo);
                if (res.Equals(DialogResult.Yes))
                {
                    studentListInfo.StudentId = studentIdBox.Text;
                    studentListService.DeleteStudent(studentListInfo);
                    MessageBox.Show("Deleted..", "Message:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    studentListGrid.DataSource = null;
                    studentListGrid.DataSource = studentListService.GetAllStudentList();
                    studentIdBox.Text = "";
                }
                else
                {
                    studentListGrid.DataSource = null;
                    studentListGrid.DataSource = studentListService.GetAllStudentList();
                }
            }
            else
                MessageBox.Show("Can not be empty");

           
        }

        //private void searchBtn_Click(object sender, EventArgs e)
        //{

            //List<StudentListInfo> studentList = new List<StudentListInfo>();
            //studentListInfo.StudentId = searchIdBox.Text;
            //studentList.Add(studentListService.GetStudentById(studentListInfo));
            //dataGridView1.DataSource = s;
            //studentListInfo.StudentId = searchIdBox.Text;
            //studentListService.GetStudentById(studentListInfo);

            //DataTable dataTable1 = new DataTable();
            //dataTable1 = studentListService.GetStudentById();
            //studentListGrid.DataSource = dataTable1;

            //studentListGrid.DataSource = null;

            //studentListGrid.DataSource = studentListService.GetAllStudentById();
        //}

        private void searchIdBox_OnValueChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dataTable);
            dv.RowFilter = string.Format("StudentName LIKE '%{0}%'", searchIdBox.Text);
            studentListGrid.DataSource = dv;
        }
    }
}
