using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
using System.Data;

namespace Services
{
    public class AddCourseOutlineService
    {
        AddCourseOutlineAccess addCourseOutlineAccess = new AddCourseOutlineAccess();

        public DataTable GetAllRegisteredCourse(AddCourseOutlineInfo courseOutlineInfo)
        {
            return addCourseOutlineAccess.GetAllCourses(courseOutlineInfo.FacultyId);
        }

        public DataTable GetAllCourseOutline(AddCourseOutlineInfo courseOutlineInfo)
        {
            string sectionTable = courseOutlineInfo.CourseName + courseOutlineInfo.Section;
            return addCourseOutlineAccess.GetAllOutline(sectionTable);
        }

        public void InsertOutline(AddCourseOutlineInfo courseOutlineInfo)
        {
            string sectionTable = courseOutlineInfo.CourseName + courseOutlineInfo.Section;
            addCourseOutlineAccess.InsertOutline(sectionTable,courseOutlineInfo.Outline);
        }
    }
}
