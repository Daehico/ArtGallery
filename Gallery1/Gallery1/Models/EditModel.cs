using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class EditModel
    {
        public ArtWork ArtWorks { get; set; }
        public PhotoArt PhotoArt { get; set; }
        public IEnumerable<PhotoArt> PhotoArts { get; set; }
        public IEnumerable<ArtWork> ArtWork { get; set; }
        public IEnumerable<Author> Authors { get; set; }

        //дроп автор
        public Nullable<int> AuthorId { get; set; }
        public List<Author> AuthorsCollection { get; set; }

        //дроп тип
        public Nullable<int> TypeId { get; set; }
        public List<Type> TypesCollection { get; set; }

        //дроп жанр
        public Nullable<int> GenreId { get; set; }
        public List<Genre> GenresCollection { get; set; }

        //дроп технологии
        public Nullable<int> TechniqueId { get; set; }
        public List<Technique> TechniquesCollection { get; set; }


        //дроп локации
        public Nullable<int> LocationId { get; set; }
        public List<Location> LocationsCollection { get; set; }

        public Nullable<int> PhotoArtId { get; set; }
        public List<PhotoArt> PhotoArtCollection { get; set; }
    }
}