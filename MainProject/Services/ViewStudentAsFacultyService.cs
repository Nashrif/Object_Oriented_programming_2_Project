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
    public class ViewStudentAsFacultyService
    {
        ViewStudentAsFacultyAccess viewStudentAsFacultyAccess = new ViewStudentAsFacultyAccess();

        public DataTable GetAllourse(ViewStudentAsFacultyInfo viewStudentAsFacultyInfo)
        {
            
            return viewStudentAsFacultyAccess.GetAllCourse(viewStudentAsFacultyInfo.FacultyId);
        }

        public DataTable GetAllStudent(ViewStudentAsFacultyInfo viewStudentAsFacultyInfo)
        {
            string sectionTable = viewStudentAsFacultyInfo.CourseName + viewStudentAsFacultyInfo.CourseSection;
            return viewStudentAsFacultyAccess.GetAllStudent(sectionTable);
        }

        public void RemoveStudent(ViewStudentAsFacultyInfo viewStudentAsFacultyInfo)
        {
            string sectionTable = viewStudentAsFacultyInfo.CourseName + viewStudentAsFacultyInfo.CourseSection;
            viewStudentAsFacultyAccess.RemoveStudent(sectionTable,viewStudentAsFacultyInfo.StudentId,viewStudentAsFacultyInfo.StudentName,viewStudentAsFacultyInfo.CourseName,viewStudentAsFacultyInfo.CourseSection);
        }
    }
}
