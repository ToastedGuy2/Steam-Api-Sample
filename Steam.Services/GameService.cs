using System;
using System.Collections.Generic;
using Steam.Entities;
using Steam.Entities.ResourcesParameters;
using Steam.Repositories;
using Steam.Repositories.Generic;
using Steam.Services.Generic;

namespace Steam.Services
{
    public class GameService : GenericService<Game>, IGameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGenericRepository<Game> genericRepository, IGameRepository gameRepository) : base(genericRepository)
        {
            this._gameRepository = gameRepository ?? throw new ArgumentNullException(nameof(gameRepository));
        }

        public IEnumerable<Game> GetGamesByPublisherId(Guid publisherId, GameResourceParameters gameResourceParameters)
        {
            return _gameRepository.GetGamesByPublisherId(publisherId, gameResourceParameters);
        }
    }
}