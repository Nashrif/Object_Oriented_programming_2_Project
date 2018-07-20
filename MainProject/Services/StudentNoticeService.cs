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
    public class StudentNoticeService
    {
        StudentNoticeAccess studentNoticeAccess = new StudentNoticeAccess();
        public DataTable GetNoticeSubject(StudentNoticeInfo studentNoticeInfo)
        {
            string sectionTable = studentNoticeInfo.CourseName + studentNoticeInfo.CourseSection;
            return studentNoticeAccess.GetNoticeSubject(sectionTable);
        }

        public DataTable GetCourse(StudentNoticeInfo studentNoticeInfo)
        {
            return studentNoticeAccess.GetCouse(studentNoticeInfo.StudentId);
        }

        public DataTable GetNotice(StudentNoticeInfo studentNoticeInfo)
        {
            string sectionTable = studentNoticeInfo.CourseName + studentNoticeInfo.CourseSection;
            return studentNoticeAccess.GetNotice(sectionTable,studentNoticeInfo.NoticeSubject);
        }
    }
}
