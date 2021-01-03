using System;
using System.Collections.Generic;

#nullable disable

namespace FeedBackDAL.Models
{
    public partial class PostInfo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Post { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
