using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ModuleTopic
    {
        public int ModuleTopicID { get; set; }
        public int ModuleID { get; set; }
        public int TopicID { get; set; }
        public ModuleTopic()
        {

        }
        public ModuleTopic(int moduleTopicID,int moduleID,int topicID)
        {
            ModuleTopicID = moduleTopicID;
            ModuleID = moduleID;
            TopicID = topicID;
        }
    }
}
