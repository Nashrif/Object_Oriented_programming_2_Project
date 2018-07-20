using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AddCourseEntities
    {
        public string CourseName { get; set; }
        public string SectionName1 { get; set; }
        public string SectionName2 { get; set; }
        public string SectionName3 { get; set; }
        public string SectionName4 { get; set; }
        public string SectionName5 { get; set; }
        public int SectionNumber { get; set; }

        public string Section1StartingTime { get; set; }
        public string Section1EndingTime { get; set; }
        public string Section1FirstDay { get; set; }
        public string Section1SecondDay{ get; set; }

        public string Section2StartingTime { get; set; }
        public string Section2EndingTime { get; set; }
        public string Section2FirstDay { get; set; }
        public string Section2SecondDay { get; set; }

        public string Section3StartingTime { get; set; }
        public string Section3EndingTime { get; set; }
        public string Section3FirstDay { get; set; }
        public string Section3SecondDay { get; set; }
    }
}
