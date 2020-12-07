using System;
using System.Collections.Generic;
using Steam.Entities;
using Steam.Entities.ResourcesParameters;
using Steam.Services.Generic;

namespace Steam.Services
{
    public interface IGameService : IGenericService<Game>
    {
        IEnumerable<Game> GetGamesByPublisherId(Guid publisherId, GameResourceParameters gameResourceParameters);
    }
}