using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class TypeLocation
    {
        public int Id { get; set; }
        public string NameType { get; set; }

        public ICollection<Location> Locations { get; set; }

        public TypeLocation()
        {
            Locations = new List<Location>();
        }
    }
}