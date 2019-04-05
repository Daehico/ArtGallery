using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public ICollection<User> Users { get; set; }

        public Role()
        {
            Users = new List<User>();
        }
    }
}