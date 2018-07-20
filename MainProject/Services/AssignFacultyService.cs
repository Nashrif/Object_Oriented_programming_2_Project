using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace Services
{
    public class AssignFacultyService
    {
        AssignFacultyAccess assignFacultyAccess = new AssignFacultyAccess();

        public DataTable GetAllFaculty()
        {
            return assignFacultyAccess.GetAllFaculties();
        }

        public DataTable GetAllcourse()
        {
            return assignFacultyAccess.GetAllCourses();
        }

        public void AssignFaculty(AssignFacultyInfo assignFacultyInfo)
        {
            string sectionTable = assignFacultyInfo.CourseName + assignFacultyInfo.Section;
            assignFacultyAccess.AssignAFaculty(assignFacultyInfo.CourseName,assignFacultyInfo.Faculty,assignFacultyInfo.Section,sectionTable,assignFacultyInfo.FacultyId);
        }
    }
}
