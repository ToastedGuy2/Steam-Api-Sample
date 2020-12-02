using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Steam.Entities
{
    [Table("GameGenre")]
    public class GameGenre
    {
        public Guid GameId { get; set; }
        [ForeignKey("GameId")]
        public Game Game { get; set; }
        public Guid GenreId { get; set; }
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }
    }
}