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
    public class InsertCourseProgressService
    {
        InsertCourseProgressAccess insertCourseProgressAccess = new InsertCourseProgressAccess();

        public DataTable GetAllCourse(InsertCourseProgressInfo insertCourseProgressInfo)
        {
            return insertCourseProgressAccess.GetAllCourse(insertCourseProgressInfo.FacultyId);
        }

        public DataTable GetAllOutline(InsertCourseProgressInfo insertCourseProgressInfo)
        {
            string sectionTable = insertCourseProgressInfo.CourseName + insertCourseProgressInfo.Section;
            return insertCourseProgressAccess.GetAllOutline(sectionTable);
        }

        public void InsertPercentage(InsertCourseProgressInfo insertCourseProgressInfo)
        {
            string sectionTable = insertCourseProgressInfo.CourseName + insertCourseProgressInfo.Section;
            insertCourseProgressAccess.InsertPercentage(sectionTable,insertCourseProgressInfo.Outline,insertCourseProgressInfo.Percentage);
        }
    }
}
