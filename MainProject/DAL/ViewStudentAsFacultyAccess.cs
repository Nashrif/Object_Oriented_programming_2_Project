using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class ViewStudentAsFacultyAccess
    {
        SqlConnection con;

        public ViewStudentAsFacultyAccess()
        {
            con = new SqlConnection(@"Data Source=RIAN;Initial Catalog=adminuser;Integrated Security=True");
            //con = new SqlConnection(@"Data Source=DESKTOP-ICT4MT5;Initial Catalog=projectDatabase;Integrated Security=True");
            con.Open();
        }

        public DataTable GetAllCourse(string facultyId)
        {
            string s = "Select CourseName,Section from "+facultyId+"";
            SqlCommand str = new SqlCommand(s, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable GetAllStudent(string sectionTable)
        {
            string s = "Select StudentList,StudentId from " + sectionTable + "";
            SqlCommand str = new SqlCommand(s, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void RemoveStudent(string sectionTable, string studentId, string studentName,string courseName,string courseSection)
        {
            string s = "UPDATE " + sectionTable + " SET StudentList=null,StudentId=null WHERE StudentList='" + studentName + "' and StudentId='" + studentId + "'";
            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();


            string s2 = "UPDATE " + studentId + " SET CourseName=null,Section=null WHERE CourseName='" + courseName + "' and Section='" + courseSection + "'";
            SqlCommand str2 = new SqlCommand(s2, con);
            str2.ExecuteNonQuery();

            MessageBox.Show("Student removed");
        }
    }
}
