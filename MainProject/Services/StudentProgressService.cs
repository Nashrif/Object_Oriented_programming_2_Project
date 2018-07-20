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
    public class StudentProgressService
    {
        StudentProgressAccess studentProgressAccess = new StudentProgressAccess();

        public DataTable GetCourse(StudentProgressInfo studentProgressInfo)
        {
            return studentProgressAccess.GetCourse(studentProgressInfo.StudentId);
        }

        public DataTable GetTopic(StudentProgressInfo studentProgressInfo)
        {
            string sectionTable = studentProgressInfo.CourseName + studentProgressInfo.CourseSection;
            return studentProgressAccess.GetTopic(sectionTable,studentProgressInfo.Topic);
        }
    }
}
