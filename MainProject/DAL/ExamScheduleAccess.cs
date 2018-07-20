using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL
{
    public class ExamScheduleAccess
    {
        SqlConnection con;

        public ExamScheduleAccess()
        {
            con = new SqlConnection(@"Data Source=RIAN;Initial Catalog=adminuser;Integrated Security=True");
            // con = new SqlConnection(@"Data Source=DESKTOP-ICT4MT5;Initial Catalog=projectDatabase;Integrated Security=True");
            con.Open();
        }
        public DataTable GetExam(string studentId)
        {
            string s = "Select CourseName,Section from " + studentId + "";
            SqlCommand str = new SqlCommand(s, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable GetSchedule(string studentId, string course)
        {
            string s = "Select CourseName,ExamDate from ExamTimeTable where CourseName='"+course+"'";
            SqlCommand str = new SqlCommand(s, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
