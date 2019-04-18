using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class PhotoArt
    {
        public int Id { get; set; }
        public string PhotoName { get; set; }
        public byte[] Photo { get; set; }

        public ICollection<ArtWork> ArtWorks { get; set; }

        public PhotoArt()
        {
            ArtWorks = new List<ArtWork>();
        }
    }
}