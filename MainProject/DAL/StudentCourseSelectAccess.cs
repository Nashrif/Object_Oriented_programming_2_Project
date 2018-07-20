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
    public class StudentCourseSelectAccess
    {
        SqlConnection con;

        public StudentCourseSelectAccess()
        {
            con = new SqlConnection(@"Data Source=RIAN;Initial Catalog=adminuser;Integrated Security=True");
            // con = new SqlConnection(@"Data Source=DESKTOP-ICT4MT5;Initial Catalog=projectDatabase;Integrated Security=True");
            con.Open();
        }

        public DataTable GetAllCourse()
        {
            string s = "Select CourseName,CourseId from CourseTable";
            SqlCommand str = new SqlCommand(s, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable GetAllSection(string course)
        {
            string s = "Select Section,FirstDay,SecondDay,StartingTime,EndingTime from "+course+"";
            SqlCommand str = new SqlCommand(s, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void InsertCourseToStudent(string studentName, string studentId, string courseName, string courseSection, string sectionTable)
        {
            string s = "INSERT INTO " + sectionTable + " (StudentList,StudentId) VALUES ('" + studentName + "','" + studentId + "')";
            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();

            //string s1 = "INSERT INTO "+studentId+" (StudentName,StudentId,CourseName,Section,FirstDay,SecondDay,StartingTime,EndingTime,NumberOfCourse,Faculty)" +
            //    "VALUES ('"+studentName+ "','" + studentId + "','" + firstCourse + "','" + firstSection + "',(SELECT FirstDay from "+firstCourse+" where Section='"+firstSection+"'),(SELECT SecondDay from "+firstCourse+ " where Section='" + firstSection + "'),(SELECT StartingTime from " + firstCourse + " where Section='" + firstSection + "'),(SELECT EndingTime from " + firstCourse + " where Section='" + firstSection + "'),'" + numberOfCourse+ "',(SELECT Faculty from " + sectionTable + " where CourseName='"+firstCourse+"')";


            string s1 = "INSERT INTO " + studentId + " (StudentName,StudentId,CourseName,Section,FirstDay,SecondDay,StartingTime,EndingTime) " +
                "VALUES ('" + studentName + "','" + studentId + "','" + courseName + "','" + courseSection + "',(SELECT FirstDay From " + courseName + " where Section='"+courseSection+"' and CourseName='"+courseName+"'),(SELECT SecondDay From " + courseName + " where Section='" + courseSection + "' and CourseName='" + courseName + "'),(SELECT StartingTime From " + courseName + " where Section='" + courseSection + "' and CourseName='" + courseName + "'),(SELECT EndingTime From " + courseName + " where Section='" + courseSection + "' and CourseName='" + courseName + "'))";
            SqlCommand str1 = new SqlCommand(s1, con);
            str1.ExecuteNonQuery();

            string s2 = "UPDATE "+studentId+" SET Faculty=(SELECT Faculty from "+sectionTable+" where CourseName='"+courseName+"' and Section='"+courseSection+"') where CourseName='"+courseName+"' and Section='"+courseSection+"'";
            SqlCommand str2 = new SqlCommand(s2, con);
            str2.ExecuteNonQuery();

            MessageBox.Show("Course Added");
        }

        //public void InsertCourseToStudent(string studentName, string studentId, string firstCourse, string firstSection,string sectionTable,string numberOfCourse)
        //{
        //    string s = "INSERT INTO "+sectionTable+" (StudentList,StudentId) VALUES ('"+studentName+"','"+studentId+"')";
        //    SqlCommand str = new SqlCommand(s, con);
        //    str.ExecuteNonQuery();

        //    //string s1 = "INSERT INTO "+studentId+" (StudentName,StudentId,CourseName,Section,FirstDay,SecondDay,StartingTime,EndingTime,NumberOfCourse,Faculty)" +
        //    //    "VALUES ('"+studentName+ "','" + studentId + "','" + firstCourse + "','" + firstSection + "',(SELECT FirstDay from "+firstCourse+" where Section='"+firstSection+"'),(SELECT SecondDay from "+firstCourse+ " where Section='" + firstSection + "'),(SELECT StartingTime from " + firstCourse + " where Section='" + firstSection + "'),(SELECT EndingTime from " + firstCourse + " where Section='" + firstSection + "'),'" + numberOfCourse+ "',(SELECT Faculty from " + sectionTable + " where CourseName='"+firstCourse+"')";


        //    string s1 = "INSERT INTO " + studentId + " (StudentName,StudentId,CourseName,Section,FirstDay,SecondDay,StartingTime,EndingTime) " +
        //        "VALUES ('" + studentName + "','" + studentId + "','" + firstCourse + "','" + firstSection + "',(SELECT FirstDay From " + firstCourse + "),(SELECT SecondDay From " + firstCourse + "),(SELECT StartingTime From " + firstCourse + "),(SELECT EndingTime From " + firstCourse +"))";
        //    SqlCommand str1 = new SqlCommand(s1, con);
        //    str1.ExecuteNonQuery();

        //    //string s2 = "INSERT INTO " + studentId + " (FirstDay,SecondDay,StartingTime,EndingTime) SELECT FirstDay,SecondDay,StartingTime,EndingTime From "+firstCourse+"";
        //    //SqlCommand str2 = new SqlCommand(s2, con);
        //    //str2.ExecuteNonQuery();

        //   // MessageBox.Show("Course Added");
        //}

        //public void InsertCourseToStudentC(string studentName, string studentId, string thirdCourse, string thirdSection, string sectionTable3)
        //{
        //    string s = "INSERT INTO " + sectionTable3 + " (StudentList,StudentId) VALUES ('" + studentName + "','" + studentId + "')";
        //    SqlCommand str = new SqlCommand(s, con);
        //    str.ExecuteNonQuery();

        //    //string s1 = "INSERT INTO "+studentId+" (StudentName,StudentId,CourseName,Section,FirstDay,SecondDay,StartingTime,EndingTime,NumberOfCourse,Faculty)" +
        //    //    "VALUES ('"+studentName+ "','" + studentId + "','" + firstCourse + "','" + firstSection + "',(SELECT FirstDay from "+firstCourse+" where Section='"+firstSection+"'),(SELECT SecondDay from "+firstCourse+ " where Section='" + firstSection + "'),(SELECT StartingTime from " + firstCourse + " where Section='" + firstSection + "'),(SELECT EndingTime from " + firstCourse + " where Section='" + firstSection + "'),'" + numberOfCourse+ "',(SELECT Faculty from " + sectionTable + " where CourseName='"+firstCourse+"')";


        //    string s1 = "INSERT INTO " + studentId + " (StudentName,StudentId,CourseName,Section,FirstDay,SecondDay,StartingTime,EndingTime) " +
        //        "VALUES ('" + studentName + "','" + studentId + "','" + thirdCourse + "','" + thirdSection + "',(SELECT FirstDay From " + thirdCourse + "),(SELECT SecondDay From " + thirdCourse + "),(SELECT StartingTime From " + thirdCourse + "),(SELECT EndingTime From " + thirdCourse + "))";
        //    SqlCommand str1 = new SqlCommand(s1, con);
        //    str1.ExecuteNonQuery();
        //}

        //public void InsertCourseToStudentB(string studentName, string studentId, string secondCourse, string secondSection, string sectionTable2)
        //{
        //    string s = "INSERT INTO " + sectionTable2 + " (StudentList,StudentId) VALUES ('" + studentName + "','" + studentId + "')";
        //    SqlCommand str = new SqlCommand(s, con);
        //    str.ExecuteNonQuery();

        //    //string s1 = "INSERT INTO "+studentId+" (StudentName,StudentId,CourseName,Section,FirstDay,SecondDay,StartingTime,EndingTime,NumberOfCourse,Faculty)" +
        //    //    "VALUES ('"+studentName+ "','" + studentId + "','" + firstCourse + "','" + firstSection + "',(SELECT FirstDay from "+firstCourse+" where Section='"+firstSection+"'),(SELECT SecondDay from "+firstCourse+ " where Section='" + firstSection + "'),(SELECT StartingTime from " + firstCourse + " where Section='" + firstSection + "'),(SELECT EndingTime from " + firstCourse + " where Section='" + firstSection + "'),'" + numberOfCourse+ "',(SELECT Faculty from " + sectionTable + " where CourseName='"+firstCourse+"')";


        //    string s1 = "INSERT INTO " + studentId + " (StudentName,StudentId,CourseName,Section,FirstDay,SecondDay,StartingTime,EndingTime) " +
        //        "VALUES ('" + studentName + "','" + studentId + "','" + secondCourse + "','" + secondSection + "',(SELECT FirstDay From " + secondCourse + "),(SELECT SecondDay From " + secondCourse + "),(SELECT StartingTime From " + secondCourse + "),(SELECT EndingTime From " + secondCourse + "))";
        //    SqlCommand str1 = new SqlCommand(s1, con);
        //    str1.ExecuteNonQuery();


        //}

        //public void InsertCourseToStudentA(string studentName, string studentId, string firstCourse, string firstSection, string sectionTable1)
        //{
        //    string s = "INSERT INTO " + sectionTable1 + " (StudentList,StudentId) VALUES ('" + studentName + "','" + studentId + "')";
        //    SqlCommand str = new SqlCommand(s, con);
        //    str.ExecuteNonQuery();

        //    //string s1 = "INSERT INTO "+studentId+" (StudentName,StudentId,CourseName,Section,FirstDay,SecondDay,StartingTime,EndingTime,NumberOfCourse,Faculty)" +
        //    //    "VALUES ('"+studentName+ "','" + studentId + "','" + firstCourse + "','" + firstSection + "',(SELECT FirstDay from "+firstCourse+" where Section='"+firstSection+"'),(SELECT SecondDay from "+firstCourse+ " where Section='" + firstSection + "'),(SELECT StartingTime from " + firstCourse + " where Section='" + firstSection + "'),(SELECT EndingTime from " + firstCourse + " where Section='" + firstSection + "'),'" + numberOfCourse+ "',(SELECT Faculty from " + sectionTable + " where CourseName='"+firstCourse+"')";


        //    string s1 = "INSERT INTO " + studentId + " (StudentName,StudentId,CourseName,Section,FirstDay,SecondDay,StartingTime,EndingTime) " +
        //        "VALUES ('" + studentName + "','" + studentId + "','" + firstCourse + "','" + firstSection + "',(SELECT FirstDay From " + firstCourse + "),(SELECT SecondDay From " + firstCourse + "),(SELECT StartingTime From " + firstCourse + "),(SELECT EndingTime From " + firstCourse + "))";
        //    SqlCommand str1 = new SqlCommand(s1, con);
        //    str1.ExecuteNonQuery();
        //}
    }
}
