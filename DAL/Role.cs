using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Role
    {
        public int RoleID { get; set; }
        public string RoleDescription { get; set; }
        public Role()
        {

        }
        public Role(int roleID,string roleDescription)
        {
            this.RoleID = roleID;
            this.RoleDescription = roleDescription;
        }
    }
}
