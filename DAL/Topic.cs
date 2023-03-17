using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Topic
    {
        public int TopicID { get; set; }
        public string TopicDescription { get; set; }
        public Topic()
        {

        }
        public Topic(int topicID,string topicDescription)
        {
            TopicID = topicID;
            TopicDescription = topicDescription;
        }
    }
}
