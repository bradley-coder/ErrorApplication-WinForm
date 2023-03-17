using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Error
    {
        public int ErrorID { get; set; }
        public string ErrorDescription { get; set; }
        public int StudentID { get; set; }
        public int ProgLanguageID { get; set; }
        public int ModuleTopicID { get; set; }
        public string ErrorStatus { get; set; }
        public Error()
        {

        }
        public Error(int errorID,string errorDes,int studentID,int progLangID,int moduleTopicID,string errorStatus)
        {
            ErrorID = errorID;
            ErrorDescription = errorDes;
            StudentID = studentID;
            ProgLanguageID = progLangID;
            ModuleTopicID = moduleTopicID;
            ErrorDescription = errorDes;
        }
    }
}
