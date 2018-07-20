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
    public class StudentListService
    {
        StudentListAccess studentListAccess = new StudentListAccess();

        public DataTable GetAllStudentList()
        {
           return studentListAccess.GetAllStudentList();
        }

        public void DeleteStudent(StudentListInfo studentListInfo)
        {
           studentListAccess.DeleteAStudent(studentListInfo.StudentName,studentListInfo.StudentId);
        }

        //public DataTable GetStudentById(StudentListInfo studentListInfo)
        //{
        //    return studentListAccess.GetAllStudentById(studentListInfo.StudentId);
        //}
    }
}
