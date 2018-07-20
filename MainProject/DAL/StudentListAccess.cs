using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class StudentListAccess
    {
        SqlConnection con;

        public StudentListAccess()
        {
            con = new SqlConnection(@"Data Source=RIAN;Initial Catalog=adminuser;Integrated Security=True");
            //   con = new SqlConnection(@"Data Source=DESKTOP-ICT4MT5;Initial Catalog=projectDatabase;Integrated Security=True");
            con.Open();
        }

        public DataTable GetAllStudentList()
        {

            string s = "Select * from StudentList";
            SqlCommand str = new SqlCommand(s, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        //public DataTable GetAllStudentById(string studentId)
        //{
        //    string s = "Select * from StudentTable where (StudentId='"+studentId+"')";
        //    SqlCommand str = new SqlCommand(s, con);
        //    SqlDataAdapter da = new SqlDataAdapter(str);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);

        //    return dt;
        //}

        public void DeleteAStudent(string studentName, string studentId)
        {
            string s = "Delete from loginTable where Id='"+studentId+"'";
            SqlCommand str = new SqlCommand(s, con);
            str.ExecuteNonQuery();

            string s1 = "Delete from StudentList where (StudentId='" + studentId + "')";
            SqlCommand str1 = new SqlCommand(s1, con);
            str1.ExecuteNonQuery();

            string s2 = "DROP TABLE " + studentId + "";
            SqlCommand str2 = new SqlCommand(s2, con);
            str2.ExecuteNonQuery();
        }

    }
}
