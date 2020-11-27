using System;
using System.Collections.Generic;

namespace WebApiDemo.Models
{
    public partial class Role
    {
        public Role()
        {
            User = new HashSet<User>();
        }

        public short RoleId { get; set; }
        public string RoleDesc { get; set; }

        public ICollection<User> User { get; set; }
    }
}
