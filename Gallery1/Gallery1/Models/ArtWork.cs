using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class ArtWork
    {
        public int Id { get; set; }
        public string WorkName { get; set; }
        public string OriginWorkName { get; set; }
        public string CreationDate { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }

        //внешний ключ для типа работы
        public int? TypeId { get; set; }
        public Type Type { get; set; }

        //внешний ключ для автора работы
        public int? AuthorId { get; set; }
        public Author Author { get; set; }

        //внешний ключ для жанра работы
        public int? GenreId { get; set; }
        public Genre Genre { get; set; }

        //внешний ключ для технологии работы
        public int? TechniqueId { get; set; }
        public Technique Technique { get; set; }

        //внешний ключ для места хранения работы
        public int? LocationId { get; set; }
        public Location Location { get; set; }

        //внешний ключ для фото арта
        public int? PhotoArtId { get; set; }
        public PhotoArt PhotoArt { get; set; }

    }
}