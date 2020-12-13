using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Steam.Entities
{
    [Table("Genre")]
    public class Genre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid GenreId { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<GameGenre> Games { get; set; }
         = new List<GameGenre>();
    }
}