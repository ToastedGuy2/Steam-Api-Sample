using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Steam.Entities
{
    [Table("UserGame")]
    public class UserGame
    {
        public Guid GameId { get; set; }
        [ForeignKey("GameId")]
        public Game Game { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}