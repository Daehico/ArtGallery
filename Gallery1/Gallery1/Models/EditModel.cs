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
        public PhotoArt PhotoArt { get; set; }

        public IEnumerable<PhotoArt> PhotoArts { get; set; }
        public IEnumerable<ArtWork> ArtWork { get; set; }
        public IEnumerable<Author> Authors { get; set; }
    }
}