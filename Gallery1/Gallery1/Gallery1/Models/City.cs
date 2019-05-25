using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string Region { get; set; }

        public ICollection<Location> Locations { get; set; }

        public City()
        {
            Locations = new List<Location>();
        }

        //внешний ключ для страны, где хранится работа
        public int? CountryId { get; set; }
        public Country Country { get; set; }
    }
}