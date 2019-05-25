using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        public string GenreDescription { get; set; }
        public ICollection<ArtWork> ArtWorks { get; set; }

        public Genre()
        {
            ArtWorks = new List<ArtWork>();
        }
    }
}