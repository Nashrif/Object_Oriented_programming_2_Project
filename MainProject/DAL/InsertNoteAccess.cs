using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class InsertNoteAccess
    {
        SqlConnection con;

        public InsertNoteAccess()
        {
            con = new SqlConnection(@"Data Source=RIAN;Initial Catalog=adminuser;Integrated Security=True");
            //con = new SqlConnection(@"Data Source=DESKTOP-ICT4MT5;Initial Catalog=projectDatabase;Integrated Security=True");
            con.Open();
        }

        public DataTable GetAllCourse(string facultyId)
        {
            string s = "Select CourseName,Section from " + facultyId + "";
            SqlCommand str = new SqlCommand(s, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
