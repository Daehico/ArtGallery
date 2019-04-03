using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class ArtContext : DbContext
    {
        public DbSet<Type> Types { get; set; }
        public DbSet<ArtWork> ArtWorks { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Technique> Techniques { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<TypeLocation> TypeLocations { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }

    }
}