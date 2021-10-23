using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public GenreTypes GenreType { get; set; }
        [Display(Name="Genre")]
        public byte GenreTypeId { get; set; }
        [Display(Name = "Release date")]
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public DateTime DateAdded { get; set; }
        [Display(Name="Number in stock")]
        [Range(0,20)]
        [Required]
        public short NumberInStock { get; set; }
        public short Available { get; set; }
    }
}