using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace Services
{
    public class FacultyListService
    {
        FacultyListAccess facultyListAccess = new FacultyListAccess();

        public DataTable GetAllFacultyList()
        {
            return facultyListAccess.GetAllFacultyList();

        }

        public void DeleteFaculty(FacultyListInfo facultyListInfo)
        {
            facultyListAccess.DeleteAFaculty(facultyListInfo.FacultyName,facultyListInfo.FacultyId);
        }
    }
}
