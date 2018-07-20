using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;


namespace Services
{
    public class SignUpService
    {
        LoginAccess dal = new LoginAccess();
        // List<StudentSign> studentSign = new List<StudentSign>();
        //StudentSign ss = new StudentSign();

        public void InsetStudentLoginData(Information ss)
        {
            dal.InsertStudent(ss.Name,ss.Id,ss.Password);
        }
        public void InsetFacultyLoginData(Information ss)
        {
            dal.InsertFaculty(ss.Name, ss.Id, ss.Password);
        }
    }
}
