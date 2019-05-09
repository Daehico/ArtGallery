using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gallery1.Models
{
    public class ArtWork
    {
        public int Id { get; set; }

        [Display(Name = "Название")]
        [Required(ErrorMessage = "Пожалуйста, введите название арта")]
        public string WorkName { get; set; }

        [Display(Name = "Оригинальное название")]
        [Required(ErrorMessage = "Пожалуйста, введите оригинальное название арта")]
        public string OriginWorkName { get; set; }

        [Display(Name = "Дата создания")]
        public string CreationDate { get; set; }

        [Display(Name = "Описание")]
        [Required(ErrorMessage = "Пожалуйста, введите описание")]
        public string Description { get; set; }

        [Display(Name = "Размер")]
        [Required(ErrorMessage = "Пожалуйста, введите размер арта")]
        public string Size { get; set; }

        [Display(Name = "Цена")]
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Пожалуйста, введите положительное значение цены")]
        public decimal Price { get; set; }

        //внешний ключ для типа работы
        [Display(Name = "Тип")]
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Пожалуйста, введите положительное значение типа")]
        public int? TypeId { get; set; }
        public Type Type { get; set; }

        //внешний ключ для автора работы
        [Display(Name = "Автор")]
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Пожалуйста, введите положительное значение типа")]
        public int? AuthorId { get; set; }
        public Author Author { get; set; }

        //внешний ключ для жанра работы
        [Display(Name = "Жанр")]
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Пожалуйста, введите положительное значение типа")]
        public int? GenreId { get; set; }
        public Genre Genre { get; set; }

        //внешний ключ для технологии работы
        [Display(Name = "Техника")]
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Пожалуйста, введите положительное значение типа")]
        public int? TechniqueId { get; set; }
        public Technique Technique { get; set; }

        //внешний ключ для места хранения работы
        [Display(Name = "Локация")]
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Пожалуйста, введите положительное значение типа")]
        public int? LocationId { get; set; }
        public Location Location { get; set; }

        //внешний ключ для фото арта
        [Display(Name = "Фото")]
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Пожалуйста, введите положительное значение типа")]
        public int? PhotoArtId { get; set; }
        public PhotoArt PhotoArt { get; set; }

    }
}