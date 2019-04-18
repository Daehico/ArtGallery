using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class EditModel
    {
        public ArtWork ArtWorks { get; set; }
        public Author Author { get; set; }
        public IEnumerable<Author> Authors { get; set; }
        public PhotoArt PhotoArt { get; set; }
    }
}