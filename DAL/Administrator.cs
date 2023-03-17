using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Administrator
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        //public string UserStatus { get; set; }

        public Administrator()
        {

        }
        //Add
        public Administrator(int userID,string userName,string surName,string email,string password, int roleID/*,string userStatus*/)
        {
            UserID = userID;
            UserName = userName;
            SurName = surName;
            Email = email;
            Password = password;
            RoleID = roleID;
            //UserStatus = userStatus;
        }
        //Update
        //public Administrator(string email,string password)
        //{
        //    Email = email;
        //    Password = password;
        //}
    }
}
