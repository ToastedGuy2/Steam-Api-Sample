using System;

namespace Steam.API.Models
{
    public class GameForCreationDTO
    {
        public string Name { get; set; }
        public DateTimeOffset ReleaseDate { get; set; }
        public Guid PublisherId { get; set; }

    }
}