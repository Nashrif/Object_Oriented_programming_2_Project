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
    public partial class insertNoteUserControl : UserControl
    {
        InsertNoteInfo insertNoteInfo = new InsertNoteInfo();
        InsertNoteService insertNoteService = new InsertNoteService();

        public insertNoteUserControl()
        {
            InitializeComponent();
        }

        private void insertNoteUserControl_Load(object sender, EventArgs e)
        {
            insertNoteInfo.FacultyId = LoginHelper.UserId;

            DataTable dataTable = new DataTable();
            dataTable = insertNoteService.GetAllCourse(insertNoteInfo);
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

        private void openBtn_Click(object sender, EventArgs e)
        {
            if (courseNameBox.Text != "" && sectionNameBox.Text != "")
            {
                string section = courseNameBox.Text + sectionNameBox.Text;
                string path = @"C:\Users\HP\Desktop\AIUB\project\C#\Coursefolder\" + section;
                System.Diagnostics.Process.Start(path);

                courseNameBox.Text = "";
                sectionNameBox.Text = "";
            }
            else
                MessageBox.Show("Can not be empty");
        }
    }
}
