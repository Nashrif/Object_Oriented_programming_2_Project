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
    public class AssignFacultyAccess
    {
        SqlConnection con;

        public AssignFacultyAccess()
        {
            con = new SqlConnection(@"Data Source=RIAN;Initial Catalog=adminuser;Integrated Security=True");
            // con = new SqlConnection(@"Data Source=DESKTOP-ICT4MT5;Initial Catalog=projectDatabase;Integrated Security=True");
            con.Open();
        }
        public DataTable GetAllFaculties()
        {
            string s = "Select * from FacultyList";
            SqlCommand str = new SqlCommand(s, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void AssignAFaculty(string courseName, string faculty, string section, string sectionTable,string facultyId)
        {
            string s = "UPDATE "+sectionTable+" SET Faculty='" + faculty + "' where Section='" + section + "'";
            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();

            string s1 = "INSERT INTO "+facultyId+" (FacultyName,FacultyId,CourseName,Section) VALUES ('"+faculty+"','"+facultyId+"','"+courseName+"','"+section+"')";
            SqlCommand str1 = new SqlCommand(s1, con);
            str1.ExecuteNonQuery();

            MessageBox.Show("Faculty Assigned");
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
    }
}
