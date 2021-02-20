using System;
using System.ComponentModel.DataAnnotations;

namespace Steam.Web.Models
{
    public class GameForCreationDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public DateTimeOffset ReleaseDate { get; set; }

    }
}