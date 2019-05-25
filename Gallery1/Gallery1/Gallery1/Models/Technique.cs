using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class Technique
    {
        public int Id { get; set; }
        public string TechniqueName { get; set; }
        public string TechniqueDescription { get; set; }

        public ICollection<ArtWork> ArtWorks { get; set; }

        public Technique()
        {
            ArtWorks = new List<ArtWork>();
        }
    }
}