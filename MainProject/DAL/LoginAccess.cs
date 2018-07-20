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
    public class LoginAccess
    {
        SqlConnection con;

        public LoginAccess()
        {
            con = new SqlConnection(@"Data Source=RIAN;Initial Catalog=adminuser;Integrated Security=True");
            // con = new SqlConnection(@"Data Source=DESKTOP-ICT4MT5;Initial Catalog=projectDatabase;Integrated Security=True");
            con.Open();
        }

        public void InsertStudent(string name,string id,string password)
        {

            string s = "INSERT INTO loginTable (Name,Id,Password,UserType) VALUES ('"+name+"','"+id+"','"+password+"',3)";

            SqlCommand str = new SqlCommand(s, con);
         
            str.ExecuteNonQuery();

            string s1 = "INSERT INTO StudentList (StudentName,StudentId) VALUES ('" + name + "','" + id + "')";

            SqlCommand str1 = new SqlCommand(s1, con);

            str1.ExecuteNonQuery();

            string s2 = "CREATE TABLE " + id + "" + "(" +
              "StudentName varchar(50)," +
              "StudentId varchar(50)," +
              "CourseName varchar(50)," +
              "Section varchar(50)," +
              "FirstDay varchar(50)," +
              "SecondDay varchar(50)," +
              "StartingTime varchar(50)," +
              "EndingTime varchar(50)," +
              //"NumberOfCourse varchar(50)," +
              "Faculty varchar(50)," + ");";

            SqlCommand str2 = new SqlCommand(s2, con);

            str2.ExecuteNonQuery();

        }

        public DataTable GetUserCourse(string id)
        {
            string s = "Select * from "+id+"";
            SqlCommand str = new SqlCommand(s, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void InsertFaculty(string name, string id, string password)
        {

            string s = "INSERT INTO loginTable (Name,Id,Password,UserType) VALUES ('" + name + "','" + id + "','" + password + "',2)";

            SqlCommand str = new SqlCommand(s, con);

            str.ExecuteNonQuery();

            string s1 = "INSERT INTO FacultyList (FacultyName,FacultyId) VALUES ('" + name + "','" + id + "')";

            SqlCommand str1 = new SqlCommand(s1, con);

            str1.ExecuteNonQuery();

            string s2 = "CREATE TABLE " + id + "" + "(" +
               "FacultyName varchar(50)," +
               "FacultyId varchar(50)," +
               "CourseName varchar(50)," +
               "Section varchar(50)," + ");";

            SqlCommand str2 = new SqlCommand(s2, con);

            str2.ExecuteNonQuery();

            //string s3 = "UPDATE " + id + " SET (FacultyName,FacultyId) VALUES ('" + name + "','" + id + "')";
            ////string s4 = "UPDATE " + id + " SET (FacultyName,FacultyId) '" + name + "' and FacultyId='" + id + "'";

            //SqlCommand str3 = new SqlCommand(s3, con);

            //str3.ExecuteNonQuery();

        }

        public DataTable GetUser(string id,string password)
        {

            string s = "Select * from loginTable where Id='"+id+"' and Password='"+password+"'";
            SqlCommand str = new SqlCommand(s, con);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
