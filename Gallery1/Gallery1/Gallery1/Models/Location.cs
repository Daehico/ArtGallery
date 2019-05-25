using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public string LocationDescription { get; set; }

        public ICollection<ArtWork> ArtWorks { get; set; }

        public Location()
        {
            ArtWorks = new List<ArtWork>();
        }

        //внешний ключ для типа мечта хранения 
        public int? TypeLocationId { get; set; }
        public TypeLocation TypeLocation { get; set; }

        //внешний ключ для города, где хранится работа
        public int? CityId { get; set; }
        public City City { get; set; }

        //внешний ключ для фото локации
        public int? PhotoLocationId { get; set; }
        public PhotoLocation PhotoLocation { get; set; }
    }
}