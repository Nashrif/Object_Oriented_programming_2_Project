using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using Services;

namespace Services
{
    public class AssignedCourseService
    {
        AssignedCourseAccess assignedCourseAccess = new AssignedCourseAccess();

        public DataTable GetAllCourse(AssignedCourseInfo assignedCourseInfo)
        {
            return assignedCourseAccess.GetAllCourse(assignedCourseInfo.FacultyId);
        }
    }
}
