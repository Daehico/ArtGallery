using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class GenerUser
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        public string Address { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }
    }
}