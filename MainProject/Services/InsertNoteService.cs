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
    public class InsertNoteService
    {
        InsertNoteAccess insertNoteAccess = new InsertNoteAccess();

        public DataTable GetAllCourse(InsertNoteInfo insertNoteInfo)
        {
            return insertNoteAccess.GetAllCourse(insertNoteInfo.FacultyId);
        }
    }
}
