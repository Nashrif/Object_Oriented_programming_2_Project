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
    public class StudentRegisteredCourseService
    {
        StudentRegisteredCourseAccess studentRegisteredCourseAccess = new StudentRegisteredCourseAccess();
        public DataTable GetAllCourse(StudentRegisteredCourseInfo studentRegisteredCourseInfo)
        {
            return studentRegisteredCourseAccess.GetRegisteredCourses(studentRegisteredCourseInfo.StudentId);
        }

        public void DropCourse(StudentRegisteredCourseInfo studentRegisteredCourseInfo)
        {
            string sectionTable = studentRegisteredCourseInfo.CourseName + studentRegisteredCourseInfo.CourseSection;
            studentRegisteredCourseAccess.DropCourse(studentRegisteredCourseInfo.StudentId, studentRegisteredCourseInfo.StudentName, sectionTable,studentRegisteredCourseInfo.CourseName,studentRegisteredCourseInfo.CourseSection);
        }
    }
}
