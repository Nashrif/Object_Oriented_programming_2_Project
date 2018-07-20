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
    public partial class setExamTimeUserControl : UserControl
    {
        ExamInfo examInfo = new ExamInfo();
        ExamTimeService examTimeService = new ExamTimeService();
        public DateTime datePicker;

        DataTable dataTable;

        public setExamTimeUserControl()
        {
            InitializeComponent();
        }

        private void setExamTimeUserControl_Load(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            dataTable = examTimeService.GetAllCourse();
            examDataGrid.DataSource = dataTable;
        }


        private void examDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.examDataGrid.Rows[e.RowIndex];
               
                courseNameBox.Text = row.Cells[0].Value.ToString();
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (courseNameBox.Text != "")
            {
                examInfo.CourseName = courseNameBox.Text;

                examInfo.ExamTime = dateTimePicker.Value.ToString();

                examTimeService.InsertExamTime(examInfo);

                DataTable dataTable = new DataTable();
                dataTable = examTimeService.GetAllCourse();
                examDataGrid.DataSource = dataTable;

                courseNameBox.Text = "";
            }
            else
                MessageBox.Show("can not be empty");

          
        }

        private void searchIdBox_OnValueChanged(object sender, EventArgs e)
        {
            DataView dataView = new DataView(dataTable);
            dataView.RowFilter= string.Format("CourseName LIKE '%{0}%'", searchIdBox.Text);
            examDataGrid.DataSource = dataView;
        }
    }
}
