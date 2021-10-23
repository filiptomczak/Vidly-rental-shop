using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public byte GenreTypeId { get; set; }
        public GenreTypeDTO GenreType { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Range(0, 20)]
        [Required]
        public short NumberInStock { get; set; }
    }
}