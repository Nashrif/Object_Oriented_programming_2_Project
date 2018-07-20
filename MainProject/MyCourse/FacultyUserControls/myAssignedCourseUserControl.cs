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

namespace MyCourse
{
    public partial class myAssignedCourseUserControl : UserControl
    {
        AssignedCourseInfo assignedCourseInfo = new AssignedCourseInfo();
        AssignedCourseService assignedCourseService = new AssignedCourseService();

        public myAssignedCourseUserControl()
        {
            InitializeComponent();
        }

        private void myAssignedCourseUserControl_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            assignedCourseInfo.FacultyId = LoginHelper.UserId;
            dataTable = assignedCourseService.GetAllCourse(assignedCourseInfo);
            AssignedGrid.DataSource = dataTable;
        }
    }
}
