using System;
using System.Collections.Generic;

#nullable disable

namespace FeedBackDAL.Models
{
    public partial class UserInfo
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string FullName { get; set; }
    }
}
