using System;
using System.Collections.Generic;

#nullable disable

namespace FeedBackDAL.Models
{
    public partial class VoteInfo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public int CommentId { get; set; }
        public bool AggreByVote { get; set; }
    }
}
