using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string NameAuthor { get; set; }
        public string Pseudonum { get; set; }
        public string DateOfBirth { get; set; }
        public string DateOfDeath { get; set; }
        public string Biography { get; set; }
        public string Education { get; set; }
        public string Sex { get; set; }

        public ICollection<ArtWork> ArtWorks { get; set; }
        public IEnumerable<Author> authors;

        public Author()
        {
            ArtWorks = new List<ArtWork>();
        }
    }
}