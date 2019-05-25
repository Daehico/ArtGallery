using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class School
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string Description { get; set; }
        public string CreationDateOfSchool { get; set; }

        public ICollection<ArtWork> ArtWorks { get; set; }

        public School()
        {
            ArtWorks = new List<ArtWork>();
        }
    }
}