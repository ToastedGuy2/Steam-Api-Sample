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
        public Guid GameId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTimeOffset ReleaseDate { get; set; }
        public Guid PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set; }
        public ICollection<UserGame> UsersWhoBoughtTheGame { get; set; }
         = new List<UserGame>();
        public ICollection<GameGenre> Genres { get; set; }
        = new List<GameGenre>();
    }
}