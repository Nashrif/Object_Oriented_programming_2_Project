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
    public class InsertNoticeService
    {
        InsertNoticeAccess insertNoticeAccess = new InsertNoticeAccess();

        public DataTable GetAllCourse(InsertNoticeInfo insertNoticeInfo)
        {
            return insertNoticeAccess.GetAllCourse(insertNoticeInfo.FacultyId);
        }

        public void InsertNotice(InsertNoticeInfo insertNoticeInfo)
        {
            string sectionTable = insertNoticeInfo.CourseName + insertNoticeInfo.CourseSection;
            insertNoticeAccess.InsertNotice(sectionTable,insertNoticeInfo.CourseSubject,insertNoticeInfo.CourseNotice);
        }
    }
}
