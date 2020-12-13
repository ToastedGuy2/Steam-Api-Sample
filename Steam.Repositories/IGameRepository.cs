using System;
using System.Collections;
using System.Collections.Generic;
using Steam.Entities;
using Steam.Entities.ResourcesParameters;
using Steam.Repositories.Generic;

namespace Steam.Repositories
{
    public interface IGameRepository : IGenericRepository<Game>
    {
        IEnumerable<Game> GetGamesByPublisherId(Guid publisherId, GameResourceParameters gameResourceParameters);
        Game GetGame(Guid publisherId, Guid gameId);
    }
}