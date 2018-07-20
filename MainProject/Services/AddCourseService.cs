using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
namespace Services
{
    public class AddCourseService
    {
        AddCourseAccess dal = new AddCourseAccess();

        public void AddCourse(AddCourseEntities addCourseEntities)
        {
            if(addCourseEntities.SectionNumber==1)
            {
                string sectionTable = addCourseEntities.CourseName + addCourseEntities.SectionName1;
                dal.InsertCourseTable1Section(addCourseEntities.CourseName,addCourseEntities.SectionName1);
                dal.Create1Section(addCourseEntities.CourseName, addCourseEntities.SectionName1,sectionTable);
                dal.InsertInto1Section(addCourseEntities.CourseName, addCourseEntities.SectionName1,sectionTable,addCourseEntities.Section1FirstDay,addCourseEntities.Section1SecondDay,addCourseEntities.Section1StartingTime,addCourseEntities.Section1EndingTime);
            }

            if (addCourseEntities.SectionNumber == 2)
            {
                string sectionTable1 = addCourseEntities.CourseName + addCourseEntities.SectionName1;
                string sectionTable2= addCourseEntities.CourseName + addCourseEntities.SectionName2;
                dal.InsertCourseTable2Section(addCourseEntities.CourseName, addCourseEntities.SectionName1,addCourseEntities.SectionName2);
                dal.Create2Section(addCourseEntities.CourseName, addCourseEntities.SectionName1, sectionTable1,sectionTable2);

                dal.InsertInto2SectionA(addCourseEntities.CourseName, addCourseEntities.SectionName1, sectionTable1,
                    addCourseEntities.Section1FirstDay, addCourseEntities.Section1SecondDay,
                    addCourseEntities.Section1StartingTime, addCourseEntities.Section1EndingTime);

                dal.InsertInto2SectionB(addCourseEntities.CourseName, addCourseEntities.SectionName2, sectionTable2,
                    addCourseEntities.Section2FirstDay, addCourseEntities.Section2SecondDay,
                     addCourseEntities.Section2StartingTime, addCourseEntities.Section2EndingTime);
            }

            if (addCourseEntities.SectionNumber == 3)
            {
                string sectionTable1 = addCourseEntities.CourseName + addCourseEntities.SectionName1;
                string sectionTable2 = addCourseEntities.CourseName + addCourseEntities.SectionName2;
                string sectionTable3= addCourseEntities.CourseName + addCourseEntities.SectionName3;

                dal.InsertCourseTable3Section(addCourseEntities.CourseName, addCourseEntities.SectionName1, addCourseEntities.SectionName2,addCourseEntities.SectionName3);

                dal.Create3Section(addCourseEntities.CourseName, addCourseEntities.SectionName1, sectionTable1, sectionTable2,sectionTable3);

                dal.InsertInto3SectionA(addCourseEntities.CourseName, addCourseEntities.SectionName1, sectionTable1,
                    addCourseEntities.Section1FirstDay, addCourseEntities.Section1SecondDay,
                    addCourseEntities.Section1StartingTime, addCourseEntities.Section1EndingTime);

                dal.InsertInto3SectionB(addCourseEntities.CourseName, addCourseEntities.SectionName2, sectionTable2,
                    addCourseEntities.Section2FirstDay, addCourseEntities.Section2SecondDay,
                     addCourseEntities.Section2StartingTime, addCourseEntities.Section2EndingTime);

                dal.InsertInto3SectionC(addCourseEntities.CourseName, addCourseEntities.SectionName3, sectionTable3,
                   addCourseEntities.Section3FirstDay, addCourseEntities.Section3SecondDay,
                    addCourseEntities.Section3StartingTime, addCourseEntities.Section3EndingTime);
            }
        }
    }
}
