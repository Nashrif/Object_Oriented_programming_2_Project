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
    public class ExamTimeAccess
    {
        SqlConnection con;

        public ExamTimeAccess()
        {
            con = new SqlConnection(@"Data Source=RIAN;Initial Catalog=adminuser;Integrated Security=True");
            // con = new SqlConnection(@"Data Source=DESKTOP-ICT4MT5;Initial Catalog=projectDatabase;Integrated Security=True");
            con.Open();
        }

        public DataTable GetAllCourse()
        {

            string s = "Select * from ExamTimeTable";
            SqlCommand str = new SqlCommand(s, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable InsertExamTimeAccess(string courseName, string examTime)
        {
            string s = "UPDATE ExamTimeTable SET ExamDate='"+examTime+"' where CourseName='"+courseName+"'" ;
            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("Date Inserted");
            return dt;
        }
    }
}
