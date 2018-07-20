using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;
using System.Data;

namespace Services
{
    public class LoginService
    {
        LoginAccess DataAccess = new LoginAccess();
        
        public DataTable GetLogin(Information information)
        {
           return  DataAccess.GetUser(information.Id, information.Password);
        }

        public DataTable GetUserCourse(Information information)
        {
            return DataAccess.GetUserCourse(information.Id);
        }

        public DataTable GetUserCourse(string userId)
        {
            return DataAccess.GetUserCourse(userId);
        }
    }
}
