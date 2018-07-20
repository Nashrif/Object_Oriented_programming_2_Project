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
    public class StudentNoteService
    {
        StudentNoteAccess studentNoteAccess = new StudentNoteAccess();

        public DataTable GetCourse(StudentNoteInfo studentNoteInfo)
        {
            return studentNoteAccess.GetCourse(studentNoteInfo.StudentId);
        }
    }
}
