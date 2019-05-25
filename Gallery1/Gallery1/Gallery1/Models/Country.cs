using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string DescriptionCountry { get; set; }
        public string Capital { get; set; }
        public string Language { get; set; }

        public ICollection<City> Citys { get; set; }

        public Country()
        {
            Citys = new List<City>();
        }
    }
}