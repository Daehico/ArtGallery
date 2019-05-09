using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class PhotoLocation
    {
        public int Id { get; set; }
        public string NamePhotoLocation { get; set; }
        public byte[] PhotoLocationArt { get; set; }

        public ICollection<Location> Locations { get; set; }

        public PhotoLocation()
        {
            Locations = new List<Location>();
        }
    }
}