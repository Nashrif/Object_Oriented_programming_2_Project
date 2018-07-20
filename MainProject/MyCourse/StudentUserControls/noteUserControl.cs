using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Services;
using Entities;

namespace MyCourse
{
    public partial class noteUserControl : UserControl
    {
        StudentNoteInfo studentNoteInfo = new StudentNoteInfo();
        StudentNoteService studentNoteService = new StudentNoteService();

        List<string> listFiles = new List<string>();

        public noteUserControl()
        {
            InitializeComponent();
        }

        private void firstCourseFolder_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("E:\\study");
            listFiles.Clear();
            listView.Items.Clear();
            string sectionTable = courseNameBox.Text + sectionNameBox.Text;

            string path = @"C:\Users\HP\Desktop\AIUB\project\C#\Coursefolder\" + sectionTable;

            foreach (string items in Directory.GetFiles(path))
            {
                imageList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(items));
                FileInfo fileInfo = new FileInfo(items);
                listFiles.Add(fileInfo.FullName);
                listView.Items.Add(fileInfo.Name, imageList.Images.Count - 1);
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //object Process = null;
            if (listView.FocusedItem != null)
                Process.Start(listFiles[listView.FocusedItem.Index]);
        }

        private void noteUserControl_Load(object sender, EventArgs e)
        {
            //firstCoursePanel.Visible = true;
            studentNoteInfo.StudentId = LoginHelper.UserId;
            DataTable dataTable = new DataTable();
            dataTable = studentNoteService.GetCourse(studentNoteInfo);
            courseGrid.DataSource = dataTable;
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            if (courseNameBox.Text != "" && sectionNameBox.Text != "")
            {

                firstCoursePanel.Visible = true;
                firstCourseLabel.Text = courseNameBox.Text;
            }
            else
                MessageBox.Show("Can Not Be Empty");

            
        }

        private void courseGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.courseGrid.Rows[e.RowIndex];


                courseNameBox.Text = row.Cells[0].Value.ToString();
                sectionNameBox.Text= row.Cells[1].Value.ToString();
            }
        }
    }
}
