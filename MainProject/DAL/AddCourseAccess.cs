using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class AddCourseAccess
    {
        SqlConnection con;

        public AddCourseAccess()
        {
            con = new SqlConnection(@"Data Source=RIAN;Initial Catalog=adminuser;Integrated Security=True");
            //con = new SqlConnection(@"Data Source=DESKTOP-ICT4MT5;Initial Catalog=projectDatabase;Integrated Security=True");
            con.Open();
        }


        public void InsertCourseTable1Section(string courseName, string sectionName/*, string sectionTable,string firstDay,string secondDay,string firstTime,string secondTime*/)
        {
            string s = "INSERT INTO CourseTable (CourseName,Section1) VALUES ('" + courseName + "','" + sectionName + "') ";
            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();

            string s1 = "INSERT INTO ExamTimeTable (CourseName,CourseId) VALUES ('" + courseName + "',(SELECT CourseId from CourseTable WHERE (CourseName='"+courseName+"'))) ";
            SqlCommand str1 = new SqlCommand(s1, con);
            str1.ExecuteNonQuery();
            //string val = courseName + sectionName;

            string s2= "CREATE TABLE " + courseName + " " + "(" +
                //"CourseId int FOREIGN KEY REFERENCES CreateCourseTable(CourseId)," +
                "CourseName varchar(50)," +
                "CourseId varchar(50)," +
                "Section varchar(50)," +
                "FirstDay varchar(50)," +
                "SecondDay varchar(50)," +
                "StartingTime varchar(50)," +
                "EndingTime varchar(50)," + ");";

            SqlCommand str2 = new SqlCommand(s2, con);
            str2.ExecuteNonQuery();

        }

        public void Create1Section(string courseName, string sectionName, string sectionTable)
        {
            string s = "CREATE TABLE " + sectionTable + " " + "(" +
                 //"CourseId int FOREIGN KEY REFERENCES CreateCourseTable(CourseId)," +
                "CourseName varchar(50) ," +
                "Section varchar(50)," +
                "Faculty varchar(50)," +
                "StudentList varchar(50) ," +
                "StudentId varchar(50)," +
                "OutLine varchar(50) ," +
                "Progress varchar(50)," +
                "Subject varchar(50) ," +
                "Notice varchar(200) ," + ");";

            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();
        }

        public void InsertInto2SectionA(string courseName, string sectionName1, string sectionTable1, string section1FirstDay, string section1SecondDay, string section1StartingTime, string section1EndingTime)
        {

            string s = "INSERT INTO " + courseName + " (CourseName,CourseId,Section,FirstDay,SecondDay,StartingTime,EndingTime) " +
                "VALUES ('"+courseName+"',(SELECT CourseId FROM CourseTable WHERE(CourseName='" + courseName + "')),'" + sectionName1 + "','" + section1FirstDay + "','" + section1SecondDay + "','" + section1StartingTime + "','" + section1EndingTime + "')";

            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();
           // MessageBox.Show("Course Inserted");


            string s1 = "INSERT INTO " + sectionTable1 + " (CourseName,Section) " +
                "VALUES ('" + courseName + "','" + sectionName1 + "')";

            SqlCommand str1 = new SqlCommand(s1, con);
            str1.ExecuteNonQuery();
           // MessageBox.Show("Course Inserted");
        }

        public void InsertInto2SectionB(string courseName, string sectionName2, string sectionTable2, string section2FirstDay, string section2SecondDay, string section2StartingTime, string section2EndingTime)
        {
            string s = "INSERT INTO " + courseName + " (CourseName,CourseId,Section,FirstDay,SecondDay,StartingTime,EndingTime) " +
               "VALUES ('"+courseName+"',(SELECT CourseId FROM CourseTable WHERE(CourseName='" + courseName + "')),'" + sectionName2 + "','" + section2FirstDay + "','" + section2SecondDay + "','" + section2StartingTime + "','" + section2EndingTime + "')";

            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();
           // MessageBox.Show("Course Inserted");


            string s1 = "INSERT INTO " + sectionTable2 + " (CourseName,Section) " +
                "VALUES ('" + courseName + "','" + sectionName2 + "')";

            SqlCommand str1 = new SqlCommand(s1, con);
            str1.ExecuteNonQuery();
            MessageBox.Show("Course Inserted");
        }

        public void InsertInto3SectionA(string courseName, string sectionName1, string sectionTable1, string section1FirstDay, string section1SecondDay, string section1StartingTime, string section1EndingTime)
        {

            string s = "INSERT INTO " + courseName + " (CourseName,CourseId,Section,FirstDay,SecondDay,StartingTime,EndingTime) " +
               "VALUES ('"+courseName+"',(SELECT CourseId FROM CourseTable WHERE(CourseName='" + courseName + "')),'" + sectionName1 + "','" + section1FirstDay + "','" + section1SecondDay + "','" + section1StartingTime + "','" + section1EndingTime + "')";

            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();
            // MessageBox.Show("Course Inserted");


            string s1 = "INSERT INTO " + sectionTable1 + " (CourseName,Section) " +
                "VALUES ('" + courseName + "','" + sectionName1 + "')";

            SqlCommand str1 = new SqlCommand(s1, con);
            str1.ExecuteNonQuery();
           // MessageBox.Show("Course Inserted");
        }

        public void InsertInto3SectionB(string courseName, string sectionName2, string sectionTable2, string section2FirstDay, string section2SecondDay, string section2StartingTime, string section2EndingTime)
        {
            string s = "INSERT INTO " + courseName + " (CourseName,CourseId,Section,FirstDay,SecondDay,StartingTime,EndingTime) " +
               "VALUES ('"+courseName+"',(SELECT CourseId FROM CourseTable WHERE(CourseName='" + courseName + "')),'" + sectionName2 + "','" + section2FirstDay + "','" + section2SecondDay + "','" + section2StartingTime + "','" + section2EndingTime + "')";

            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();
            // MessageBox.Show("Course Inserted");


            string s1 = "INSERT INTO " + sectionTable2 + " (CourseName,Section) " +
                "VALUES ('" + courseName + "','" + sectionName2 + "')";

            SqlCommand str1 = new SqlCommand(s1, con);
            str1.ExecuteNonQuery();
            //MessageBox.Show("Course Inserted");
        }

        public void Create3Section(string courseName, string sectionName1, string sectionTable1, string sectionTable2, string sectionTable3)
        {
            string s = "CREATE TABLE " + sectionTable1 + " " + "(" +
             //"CourseId int FOREIGN KEY REFERENCES CreateCourseTable(CourseId)," +

             "CourseName varchar(50) ," +
                "Section varchar(50) ," +
                "Faculty varchar(50) ," +
                "StudentList varchar(50) ," +
                 "StudentId varchar(50)," +
                "OutLine varchar(50) ," +
                "Progress varchar(50) ," +
                "Subject varchar(50) ," +
                "Notice varchar(200) ," + ");";

            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();

            string s1 = "CREATE TABLE " + sectionTable2 + " " + "(" +
               //"CourseId int FOREIGN KEY REFERENCES CreateCourseTable(CourseId)," +
               "CourseName varchar(50)," +
                "Section varchar(50)," +
                "Faculty varchar(50) ," +
                "StudentList varchar(50) ," +
                 "StudentId varchar(50) ," +
                "OutLine varchar(50) ," +
                "Progress varchar(50) ," +
                "Subject varchar(50) ," +
                "Notice varchar(200) ," + ");";

            SqlCommand str1 = new SqlCommand(s1, con);
            str1.ExecuteNonQuery();

            string s2 = "CREATE TABLE " + sectionTable3 + " " + "(" +
               //"CourseId int FOREIGN KEY REFERENCES CreateCourseTable(CourseId)," +
               "CourseName varchar(50) ," +
                "Section varchar(50) ," +
                "Faculty varchar(50) ," +
                "StudentList varchar(50) ," +
                 "StudentId varchar(50) ," +
                "OutLine varchar(50) ," +
                "Progress varchar(50) ," +
                "Subject varchar(50) ," +
                "Notice varchar(200) ," + ");";

            SqlCommand str2 = new SqlCommand(s2, con);
            str2.ExecuteNonQuery();
        }

        public void InsertCourseTable3Section(string courseName, string sectionName1, string sectionName2, string sectionName3)
        {
            string s = "INSERT INTO CourseTable (CourseName,Section1,Section2,Section3) VALUES ('" + courseName + "','" + sectionName1 + "','" + sectionName2 + "','" + sectionName3 + "') ";
            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();

            //string val = courseName + sectionName;
            string s1 = "INSERT INTO ExamTimeTable (CourseName,CourseId) VALUES ('" + courseName + "',(SELECT CourseId from CourseTable WHERE (CourseName='" + courseName + "'))) ";
            SqlCommand str1 = new SqlCommand(s1, con);
            str1.ExecuteNonQuery();
            //string val = courseName + sectionName;

            string s2 = "CREATE TABLE " + courseName + " " + "(" +
                 //"CourseId int FOREIGN KEY REFERENCES CreateCourseTable(CourseId)," +
                "CourseName varchar(50)," +
                "CourseId varchar(50)," +
                "Section varchar(50)," +
                "FirstDay varchar(50)," +
                "SecondDay varchar(50)," +
                "StartingTime varchar(50)," +
                "EndingTime varchar(50)," + ");";

            SqlCommand str2 = new SqlCommand(s2, con);
            str2.ExecuteNonQuery();
        }

        public void InsertInto3SectionC(string courseName, string sectionName3, string sectionTable3, string section3FirstDay, string section3SecondDay, string section3StartingTime, string section3EndingTime)
        {
            string s = "INSERT INTO " + courseName + " (CourseName,CourseId,Section,FirstDay,SecondDay,StartingTime,EndingTime) " +
               "VALUES ('"+courseName+"',(SELECT CourseId FROM CourseTable WHERE(CourseName='" + courseName + "')),'" + sectionName3 + "','" + section3FirstDay + "','" + section3SecondDay + "','" + section3StartingTime + "','" + section3EndingTime + "')";

            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();
            // MessageBox.Show("Course Inserted");


            string s1 = "INSERT INTO " + sectionTable3 + " (CourseName,Section) " +
                "VALUES ('" + courseName + "','" + sectionName3 + "')";

            SqlCommand str1 = new SqlCommand(s1, con);
            str1.ExecuteNonQuery();
            MessageBox.Show("Course Inserted");
        }

        public void Create2Section(string courseName, string sectionName1, string sectionTable1, string sectionTable2)
        {
            string s = "CREATE TABLE " + sectionTable1 + " " + "(" +
                //"CourseId int FOREIGN KEY REFERENCES CreateCourseTable(CourseId)," +
                "CourseName varchar(50) ," +
                "Section varchar(50) ," +
                "Faculty varchar(50)," +
                "StudentList varchar(50) ," +
                 "StudentId varchar(50)," +
                "OutLine varchar(50) ," +
                "Progress varchar(50) ," +
                "Subject varchar(50) ," +
                "Notice varchar(200) ," + ");";

            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();

            string s1 = "CREATE TABLE " + sectionTable2 + " " + "(" +
                //"CourseId int FOREIGN KEY REFERENCES CreateCourseTable(CourseId)," +
                "CourseName varchar(50) ," +
                "Section varchar(50) ," +
                "Faculty varchar(50) ," +
                "StudentList varchar(50) ," +
                 "StudentId varchar(50) ," +
                "OutLine varchar(50)," +
                "Progress varchar(50) ," +
                "Subject varchar(50) ," +
                "Notice varchar(200) ," + ");";

            SqlCommand str1 = new SqlCommand(s1, con);
            str1.ExecuteNonQuery();
        }

        public void InsertCourseTable2Section(string courseName, string sectionName1, string sectionName2)
        {
            string s = "INSERT INTO CourseTable (CourseName,Section1,Section2) VALUES ('" + courseName + "','" + sectionName1 + "','"+sectionName2+"') ";
            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();

            //string val = courseName + sectionName;
            string s1 = "INSERT INTO ExamTimeTable (CourseName,CourseId) VALUES ('" + courseName + "',(SELECT CourseId from CourseTable WHERE (CourseName='" + courseName + "'))) ";
            SqlCommand str1 = new SqlCommand(s1, con);
            str1.ExecuteNonQuery();
            //string val = courseName + sectionName;

            string s2 = "CREATE TABLE " + courseName + " " + "(" +
                 //"CourseId int FOREIGN KEY REFERENCES CreateCourseTable(CourseId)," +
                "CourseName varchar(50)," +
                "CourseId varchar(50)," +
                "Section varchar(50)," +
                "FirstDay varchar(50)," +
                "SecondDay varchar(50)," +
                "StartingTime varchar(50)," +
                "EndingTime varchar(50)," + ");";

            SqlCommand str2 = new SqlCommand(s2, con);
            str2.ExecuteNonQuery();
        }

        public void InsertInto1Section(string courseName, string sectionName, string sectionTable,string firstDay,string secondDay,string firstTime,string secondTime)
        {

            string s = "INSERT INTO " + courseName + " (CourseName,CourseId,Section,FirstDay,SecondDay,StartingTime,EndingTime) " +
                "VALUES ('"+courseName+"',(SELECT CourseId FROM CourseTable WHERE(CourseName='"+courseName+"')),'" + sectionName + "','" + firstDay + "','" + secondDay + "','" + firstTime + "','" + secondTime + "')";

            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();
            //MessageBox.Show("Course Inserted");


            string s1 = "INSERT INTO " + sectionTable + " (CourseName,Section) " +
                "VALUES ('" + courseName + "','" + sectionName + "')";

            SqlCommand str1 = new SqlCommand(s1, con);
            str1.ExecuteNonQuery();
            MessageBox.Show("Course Inserted");
        }
    }
}
