using System;
using System.Collections.Generic;
using System.Text;

namespace FeedBackDAL.Models
{
    public class CustomVoteInfo
    {
        public string Post { get; set; }
        public string Comment { get; set; }
        public string UserID { get; set; }
        public DateTime CommentDate { get; set; }
        public int AggreCount { get; set; }
        public int DisAggreCount { get; set; }
    }
}
