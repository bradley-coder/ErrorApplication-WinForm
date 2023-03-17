using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Year
    {
        public int YearID { get; set; }
        public string YearDescription { get; set; }
        public Year()
        {

        }
        public Year(int yearID,string yearDescription)
        {
            YearID = yearID;
            YearDescription = yearDescription;
        }
    }
}
