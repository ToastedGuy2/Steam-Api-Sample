using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Steam.Entities
{
    [Table("Game")]
    public class Game
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public Guid GameId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public DateTimeOffset ReleaseDate { get; set; }
        [Required]
        public Guid PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set; }
        public ICollection<UserGame> UsersWhoBoughtTheGame { get; set; }
         = new List<UserGame>();
        public ICollection<GameGenre> Genres { get; set; }
        = new List<GameGenre>();
    }
}