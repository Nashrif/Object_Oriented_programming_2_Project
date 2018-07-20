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
    public class InsertCourseProgressAccess
    {
        SqlConnection con;

        public InsertCourseProgressAccess()
        {
            con = new SqlConnection(@"Data Source=RIAN;Initial Catalog=adminuser;Integrated Security=True");
            //  con = new SqlConnection(@"Data Source=DESKTOP-ICT4MT5;Initial Catalog=projectDatabase;Integrated Security=True");
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

        public DataTable GetAllOutline(string sectionTable)
        {
            string s = "Select OutLine,Progress from " + sectionTable + "";
            SqlCommand str = new SqlCommand(s, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void InsertPercentage(string sectionTable, string outline, string percentage)
        {
            string s = "UPDATE " + sectionTable +" SET  Progress='" + percentage + "' WHERE (OutLine='"+outline+"')";
            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();

            MessageBox.Show("Progress Inserted");
        }
    }
}
