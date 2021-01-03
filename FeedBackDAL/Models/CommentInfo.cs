using System;
using System.Collections.Generic;

#nullable disable

namespace FeedBackDAL.Models
{
    public partial class CommentInfo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        public string Comment { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
