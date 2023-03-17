using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ProgLanguage
    {
        public int ProgLanguageID { get; set; }
        public string ProgLanguageDescription { get; set; }

        public ProgLanguage()
        {

        }
        public ProgLanguage(int progLanguage,string progLanguageDes)
        {
            ProgLanguageID = progLanguage;
            ProgLanguageDescription = progLanguageDes;
        }
    }
}
