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
    public class scheduleService
    {
        ScheduleAccess scheduleAccess = new ScheduleAccess();

        public DataTable GetCourse(ScheduleInfo scheduleInfo)
        {
            return scheduleAccess.GetCourse(scheduleInfo.StudentId,scheduleInfo.Today);
        }
    }
}
