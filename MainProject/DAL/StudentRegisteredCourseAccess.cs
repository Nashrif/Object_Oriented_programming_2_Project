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
    public class StudentRegisteredCourseAccess
    {
        SqlConnection con;

        public StudentRegisteredCourseAccess()
        {
            con = new SqlConnection(@"Data Source=RIAN;Initial Catalog=adminuser;Integrated Security=True");
            // con = new SqlConnection(@"Data Source=DESKTOP-ICT4MT5;Initial Catalog=projectDatabase;Integrated Security=True");
            con.Open();
        }
        public DataTable GetRegisteredCourses(string studentId)
        {
            string s = "Select CourseName,Section,Faculty,FirstDay,SecondDay,StartingTime,EndingTime from "+studentId+"";
            SqlCommand str = new SqlCommand(s, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void DropCourse(string studentId, string studentName, string sectionTable,string courseName,string courseSection)
        {
            string s = "UPDATE "+sectionTable+" SET StudentList=null,StudentId=null WHERE StudentList='"+studentName+"' and StudentId='"+studentId+"'";
            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();

            string s2 = "DELETE FROM " + studentId + " WHERE CourseName='" + courseName + "' and Section='" + courseSection + "'";
            SqlCommand str2 = new SqlCommand(s2, con);
            str2.ExecuteNonQuery();

            MessageBox.Show("Course Droped");
        }
    }
}
