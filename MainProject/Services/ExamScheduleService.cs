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
    public class ExamScheduleService
    {
        ExamScheduleAccess examScheduleAccess = new ExamScheduleAccess();
        
        public DataTable GetExam(ExamScheduleInfo examScheduleInfo)
        {
            return examScheduleAccess.GetExam(examScheduleInfo.StudentId);
        }

        public DataTable GetSchedule(ExamScheduleInfo examScheduleInfo)
        {
            //string section = examScheduleInfo.CourseName + examScheduleInfo.CourseSection;
            return examScheduleAccess.GetSchedule(examScheduleInfo.StudentId,examScheduleInfo.CourseName);
        }
    }
}
