using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class RefreshToken
    {
        public int TokenId { get; set; }
        public int UserId { get; set; }
        public string Token { get; set; }
        public DateTime ExpiryDate { get; set; }

        public User User { get; set; }
    }
}
