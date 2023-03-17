using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Module
    {
        public int ModuleID { get; set; }
        public string ModuleDescription{ get; set; }
        public int YearID { get; set; }
        public Module()
        {

        }
        public Module(int moduleID,string moduleDescription,int yearID)
        {
            ModuleID = moduleID;
            ModuleDescription = moduleDescription;
            YearID = yearID;
        }
    }
}
