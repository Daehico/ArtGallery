using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class Type
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string TypeDate { get; set; }

        public ICollection<ArtWork> ArtWorks { get; set; }

        public Type()
        {
            ArtWorks = new List<ArtWork>();
        }
    }
}