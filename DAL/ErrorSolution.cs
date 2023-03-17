using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ErrorSolution
    {
        public int ErrorSolutionID { get; set; }
        public int ErrorID { get; set; }
        public int SolutionID { get; set; }
        public string SolutionDate { get; set; }
        public ErrorSolution()
        {

        }
        public ErrorSolution(int errorSolutionID,int errorID,int solutionID,string solutionDate)
        {
            ErrorSolutionID = errorSolutionID;
            ErrorID = errorID;
            SolutionID = solutionID;
            SolutionDate = solutionDate;
        }
    }
}
