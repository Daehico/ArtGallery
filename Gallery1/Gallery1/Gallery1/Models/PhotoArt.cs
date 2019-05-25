using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class PhotoArt
    {
        private int photoId;

        public int Id { get; set; }
        public string PhotoName { get; set; }
        public string Photo { get; set; }

        public ICollection<ArtWork> ArtWorks { get; set; }

        public PhotoArt(string v, string fileName)
        {
            ArtWorks = new List<ArtWork>();
        }

        public PhotoArt()
        {
        }

        public PhotoArt(int photoId)
        {
            this.photoId = photoId;
        }
    }
}