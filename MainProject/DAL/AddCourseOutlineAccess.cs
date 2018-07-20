using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class AddCourseOutlineAccess
    {
        SqlConnection con;

        public AddCourseOutlineAccess()
        {
            con = new SqlConnection(@"Data Source=RIAN;Initial Catalog=adminuser;Integrated Security=True");
            // con = new SqlConnection(@"Data Source=DESKTOP-ICT4MT5;Initial Catalog=projectDatabase;Integrated Security=True");
            con.Open();
        }
        public DataTable GetAllCourses(string facultyId)
        {
            string s = "Select CourseName,Section from " + facultyId + "";
            SqlCommand str = new SqlCommand(s, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable GetAllOutline(string sectionTable)
        {
            string s = "Select OutLine from " + sectionTable + "";
            SqlCommand str = new SqlCommand(s, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void InsertOutline(string sectionTable, string outline)
        {


            string s = "INSERT INTO "+sectionTable+" (OutLine) VALUES ('"+outline+"')";
            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();

            System.Windows.Forms.MessageBox.Show("Outline Inserted");
        }
    }
}
