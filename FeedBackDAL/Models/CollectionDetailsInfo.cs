using System;
using System.Collections.Generic;
using System.Text;

namespace FeedBackDAL.Models
{
    public class CollectionDetailsInfo
    {
        public string Post { get; set; }
        public string UserID { get; set; }
        public DateTime CreateDate { get; set; }
        public int TotalComment { get; set; }
        public int PostID { get; set; }
        public List<CustomVoteInfo> VotList { get; set; }
    }
}
