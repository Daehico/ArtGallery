using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public ICollection<GenerUser> GenerUsers { get; set; }

        public User()
        {
            GenerUsers = new List<GenerUser>();
        }

        //внешний ключ для роли пользователя
        public int? RoleId { get; set; }
        public Role Role { get; set; }
    }
}