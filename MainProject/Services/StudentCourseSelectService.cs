using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Services;
using DAL;
//using Entities;

namespace Services
{
    public class StudentCourseSelectService
    {
        StudentCourseSelectAccess studentCourseSelectAccess = new StudentCourseSelectAccess();

        public DataTable GetAllCourse()
        {
            return studentCourseSelectAccess.GetAllCourse();
        }

        public DataTable GetAllSection(StudentCourseSelectInfo studentCourseSelectInfo)
        {
            return studentCourseSelectAccess.GetAllSection(studentCourseSelectInfo.CourseName);
        }

        public void InsertCourseToStudent(StudentCourseSelectInfo studentCourseSelectInfo)
        {
           
            string sectionTable = studentCourseSelectInfo.CourseName + studentCourseSelectInfo.CourseSection;
            studentCourseSelectAccess.InsertCourseToStudent(studentCourseSelectInfo.StudentName, studentCourseSelectInfo.StudentId, studentCourseSelectInfo.CourseName, studentCourseSelectInfo.CourseSection, sectionTable);
           
        }
    }
}
