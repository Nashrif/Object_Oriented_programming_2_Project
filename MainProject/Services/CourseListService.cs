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
    public class CourseListService
    {
        CourseListAccess courseListAccess = new CourseListAccess();

        public DataTable GetAllCourse()
        {
            return courseListAccess.GetAllCourses();
        }

        public void DeleteCourse(CourseListInfo courseListInfo)
        {
            
           
            
            

           
        }

        public void DeleteCourse1(CourseListInfo courseListInfo)
        {
            string sectionA = courseListInfo.CourseName + courseListInfo.Section1;
            courseListAccess.DeleteACourse(courseListInfo.CourseId, courseListInfo.CourseName, sectionA);
         
        }

        public void DeleteCourse2(CourseListInfo courseListInfo)
        {
            string sectionA = courseListInfo.CourseName + courseListInfo.Section1;
            string sectionB = courseListInfo.CourseName + courseListInfo.Section2;
            courseListAccess.DeleteBCourse(courseListInfo.CourseId, courseListInfo.CourseName, sectionA, sectionB);
        }

        public void DeleteCourse3(CourseListInfo courseListInfo)
        {
            string sectionA = courseListInfo.CourseName + courseListInfo.Section1;
            string sectionB = courseListInfo.CourseName + courseListInfo.Section2;
            string sectionC = courseListInfo.CourseName + courseListInfo.Section3;
            courseListAccess.DeleteCCourse(courseListInfo.CourseId, courseListInfo.CourseName, sectionA, sectionB,sectionC);
        }
    }
}
