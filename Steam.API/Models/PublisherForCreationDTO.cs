using System.Collections.Generic;

namespace Steam.API.Models
{
    public class PublisherForCreationDTO
    {
        public string Name { get; set; }
        public ICollection<GameForCreationDTO> GamesDeveloped { get; set; }
         = new List<GameForCreationDTO>();
    }
}