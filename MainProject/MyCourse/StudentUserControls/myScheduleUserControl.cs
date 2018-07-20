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
    public partial class myScheduleUserControl : UserControl
    {
        ScheduleInfo scheduleInfo = new ScheduleInfo();
        scheduleService scheduleService = new scheduleService();


        public myScheduleUserControl()
        {
            InitializeComponent();

            time.Text = DateTime.Now.ToString("hh:mm:ss tt");
            year.Text = DateTime.Now.ToShortDateString();
            day.Text = DateTime.Now.DayOfWeek.ToString();
            day2.Text = DateTime.Now.DayOfWeek.ToString();
        }

        private void myScheduleUserControl_Load(object sender, EventArgs e)
        {
            scheduleInfo.StudentId = LoginHelper.UserId;
            scheduleInfo.Today = day2.Text;
            DataTable dataTable = new DataTable();

            dataTable=scheduleService.GetCourse(scheduleInfo);
            scheduleGrid.DataSource = dataTable;
        }
    }
}
