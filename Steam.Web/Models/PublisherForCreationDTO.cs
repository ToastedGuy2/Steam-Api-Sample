using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Steam.Web.Models
{
    public class PublisherForCreationDTO
    {
        [Required]
        public string Name { get; set; }
        public ICollection<GameForCreationDTO> GamesPublished { get; set; }
         = new List<GameForCreationDTO>();
    }
}