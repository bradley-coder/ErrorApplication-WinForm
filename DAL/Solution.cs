using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Solution
    {
        public int SolutionID { get; set; }
        public string SolutionDescription { get; set; }
        public int LecturerID { get; set; }
        public Solution()
        {

        }
        public Solution(int solID,string solutionDesc,int lecturerID)
        {
            SolutionID = solID;
            SolutionDescription = solutionDesc;
            LecturerID = lecturerID;
        }
    }
}
