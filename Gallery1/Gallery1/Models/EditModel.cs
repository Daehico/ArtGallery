using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class EditModel : DbContext, IDisposable
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

        //дроп локации
        public Nullable<int> PhotoArtId { get; set; }
        public List<PhotoArt> PhotoArtCollection { get; set; }

        #region IDisposable Support
        private bool disposedValue = false; // Для определения избыточных вызовов

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты).
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить ниже метод завершения.
                // TODO: задать большим полям значение NULL.

                disposedValue = true;
            }
        }

        // TODO: переопределить метод завершения, только если Dispose(bool disposing) выше включает код для освобождения неуправляемых ресурсов.
        // ~EditModel() {
        //   // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
        //   Dispose(false);
        // }

        // Этот код добавлен для правильной реализации шаблона высвобождаемого класса.
        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки выше, в методе Dispose(bool disposing).
            Dispose(true);
            // TODO: раскомментировать следующую строку, если метод завершения переопределен выше.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}