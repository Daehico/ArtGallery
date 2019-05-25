using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class Author
    {
        private int i;

        public int Id { get; set; }
        public string NameAuthor { get; set; }
        public string Pseudonum { get; set; }
        public string DateOfBirth { get; set; }
        public string DateOfDeath { get; set; }
        public string Biography { get; set; }
        public string Education { get; set; }
        public string Sex { get; set; }

        public ICollection<ArtWork> ArtWorks { get; set; }

        public Author()
        {
            ArtWorks = new List<ArtWork>();
        }

        public Author(int i)
        {
            this.i = i;
        }
    }
}