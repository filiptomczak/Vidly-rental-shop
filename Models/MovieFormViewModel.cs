using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MovieFormViewModel
    {
        public IEnumerable<GenreTypes> GenreTypes{ get; set; }

        [Required]
        public int? Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public byte? GenreTypeId { get; set; }
        [Display(Name = "Release date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }
        [Display(Name = "Number in stock")]
        [Range(0, 20)]
        [Required]
        public short? NumberInStock { get; set; }
        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }
        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            NumberInStock = movie.NumberInStock;
            ReleaseDate = movie.ReleaseDate;
            GenreTypeId = movie.GenreTypeId;
        }
    }
}