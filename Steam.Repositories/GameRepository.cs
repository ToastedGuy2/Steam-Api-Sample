using System;
using System.Collections.Generic;
using System.Linq;
using Steam.Entities;
using Steam.Entities.ResourcesParameters;
using Steam.Repositories.Generic;
using Steam.Repositories.Helpers;

namespace Steam.Repositories
{
    public class GameRepository : GenericRepository<Game>, IGameRepository
    {
        public GameRepository(SteamDbContext context) : base(context)
        {
        }

        // public bool DoesGameExist(Guid gameId)
        // {
        //     return table.Any(g => g.GameId == gameId);
        // }

        public IEnumerable<Game> GetGamesByPublisherId(Guid publisherId, GameResourceParameters gameResourceParameters)
        {

            if (gameResourceParameters == null)
            {
                throw new ArgumentNullException(nameof(gameResourceParameters));
            }

            var sqlQuery = table as IQueryable<Game>;
            sqlQuery = sqlQuery.Where(g => g.PublisherId == publisherId);

            if (String.IsNullOrWhiteSpace(gameResourceParameters.SortBy))
            {
                return sqlQuery.OrderByDescending(g => g.ReleaseDate).ToList();
            }

            if (gameResourceParameters.SortBy.Trim().EqualsIgnoreCase("name"))
            {
                return !gameResourceParameters.InDescendingOrder ? sqlQuery.OrderBy(g => g.Name).ToList() : sqlQuery.OrderByDescending(g => g.Name).ToList();
            }
            if (gameResourceParameters.SortBy.Trim().EqualsIgnoreCase("price"))
            {
                return !gameResourceParameters.InDescendingOrder ? sqlQuery.OrderBy(g => g.Price).ToList() : sqlQuery.OrderByDescending(g => g.Price).ToList();
            }
            if (gameResourceParameters.SortBy.Trim().EqualsIgnoreCase("releaseDate"))
            {
                return !gameResourceParameters.InDescendingOrder ? sqlQuery.OrderBy(g => g.ReleaseDate).ToList() : sqlQuery.OrderByDescending(g => g.ReleaseDate).ToList();
            }
            return sqlQuery.OrderByDescending(g => g.ReleaseDate).ToList();
        }
    }
}
