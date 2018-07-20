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
    public class InsertNoticeAccess
    {
        SqlConnection con;

        public InsertNoticeAccess()
        {
            con = new SqlConnection(@"Data Source=RIAN;Initial Catalog=adminuser;Integrated Security=True");
            // con = new SqlConnection(@"Data Source=DESKTOP-ICT4MT5;Initial Catalog=projectDatabase;Integrated Security=True");
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

        public void InsertNotice(string sectionTable, string courseSubject, string courseNotice)
        {

            string s = "INSERT INTO " + sectionTable + " (Subject,Notice) VALUES ('" + courseSubject + "','"+courseNotice+"')";
            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();

            MessageBox.Show("Notice Posted");

            //string s1 = "UPDATE " + sectionTable + " SET Notice='" + courseNotice + "'";
            //SqlCommand str1 = new SqlCommand(s1, con);
            //str1.ExecuteNonQuery();
        }
    }
}
