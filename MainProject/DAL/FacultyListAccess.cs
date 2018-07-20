using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL
{
    public class FacultyListAccess
    {
        SqlConnection con;

        public FacultyListAccess()
        {
            con = new SqlConnection(@"Data Source=RIAN;Initial Catalog=adminuser;Integrated Security=True");
            // con = new SqlConnection(@"Data Source=DESKTOP-ICT4MT5;Initial Catalog=projectDatabase;Integrated Security=True");
            con.Open();
        }

        public DataTable GetAllFacultyList()
        {
            string s = "Select * from FacultyList";
            SqlCommand str = new SqlCommand(s, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void DeleteAFaculty(string facultyName, string facultyId)
        {
            string s = "Delete from loginTable where Id='" + facultyId + "'";
            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();

            string s1 = "Delete from FacultyList where (FacultyId='" +facultyId + "')";
            SqlCommand str1 = new SqlCommand(s1, con);
            str1.ExecuteNonQuery();

            string s2 = "DROP TABLE " + facultyId + "";
            SqlCommand str2 = new SqlCommand(s2, con);
            str2.ExecuteNonQuery();
        }
    }
}
