using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Steam.Entities
{
    [Table("Publisher")]
    public class Publisher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PublisherId { get; set; }
        public string Name { get; set; }
        public ICollection<Game> GamesPublished { get; set; }
         = new List<Game>();
    }
}