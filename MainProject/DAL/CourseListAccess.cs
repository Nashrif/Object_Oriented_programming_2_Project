using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class CourseListAccess
    {
        SqlConnection con;

        public CourseListAccess()
        {
            con = new SqlConnection(@"Data Source=RIAN;Initial Catalog=adminuser;Integrated Security=True");
            //con = new SqlConnection(@"Data Source=DESKTOP-ICT4MT5;Initial Catalog=projectDatabase;Integrated Security=True");
            con.Open();
        }
 
        public DataTable GetAllCourses()
        {
            string s = "Select * from CourseTable";
            SqlCommand str = new SqlCommand(s, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


        public void DeleteCCourse(int courseId, string courseName, string sectionA, string sectionB, string sectionC)
        {
            string s = "Delete from CourseTable where (CourseId='" + courseId + "')";
            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();

            string s4 = "Delete from ExamTimeTable where (CourseId='" + courseId + "')";
            SqlCommand str4 = new SqlCommand(s4, con);
            str4.ExecuteNonQuery();

            string s1 = "DROP TABLE " + sectionA + "";
            SqlCommand str1 = new SqlCommand(s1, con);
            str1.ExecuteNonQuery();

            string s2 = "DROP TABLE " + sectionB + "";
            SqlCommand str2 = new SqlCommand(s2, con);
            str2.ExecuteNonQuery();

            string s3 = "DROP TABLE " + sectionC + "";
            SqlCommand str3 = new SqlCommand(s3, con);
            str3.ExecuteNonQuery();

            string s5 = "DROP TABLE " + courseName + "";
            SqlCommand str5 = new SqlCommand(s5, con);
            str5.ExecuteNonQuery();
        }

        public void DeleteBCourse(int courseId, string courseName, string sectionA, string sectionB)
        {
            string s = "Delete from CourseTable where (CourseId='" + courseId + "')";
            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();

            string s4 = "Delete from ExamTimeTable where (CourseId='" + courseId + "')";
            SqlCommand str4 = new SqlCommand(s4, con);
            str4.ExecuteNonQuery();

            string s1 = "DROP TABLE " + sectionA + "";
            SqlCommand str1 = new SqlCommand(s1, con);
            str1.ExecuteNonQuery();

            string s2 = "DROP TABLE " + sectionB + "";
            SqlCommand str2 = new SqlCommand(s2, con);
            str2.ExecuteNonQuery();

            string s5 = "DROP TABLE " + courseName + "";
            SqlCommand str5 = new SqlCommand(s5, con);
            str5.ExecuteNonQuery();
        }

        public void DeleteACourse(int courseId, string courseName, string sectionA)
        {
            string s = "Delete from CourseTable where (CourseId='" + courseId + "')";
            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();

            string s4 = "Delete from ExamTimeTable where (CourseId='" + courseId + "')";
            SqlCommand str4 = new SqlCommand(s4, con);
            str4.ExecuteNonQuery();

            string s1 = "DROP TABLE " + sectionA + "";
            SqlCommand str1 = new SqlCommand(s1, con);
            str1.ExecuteNonQuery();

            string s5 = "DROP TABLE " + courseName + "";
            SqlCommand str5 = new SqlCommand(s5, con);
            str5.ExecuteNonQuery();
        }

        //public void DeleteACourse(int courseId, string section1, string section2, string section3)
        //{
        //    string s = "Delete from CreateCourseTable where (CourseId='" + courseId + "')";
        //    SqlCommand str = new SqlCommand(s, con);
        //    str.ExecuteNonQuery();

        //    string s1 = "DROP TABLE section1";
        //    SqlCommand str1 = new SqlCommand(s1, con);
        //    str1.ExecuteNonQuery();

        //    string s2 = "DROP TABLE section2";
        //    SqlCommand str2 = new SqlCommand(s2, con);
        //    str2.ExecuteNonQuery();

        //    string s3 = "DROP TABLE section3";
        //    SqlCommand str3 = new SqlCommand(s3, con);
        //    str3.ExecuteNonQuery();
        //}
    }
}
