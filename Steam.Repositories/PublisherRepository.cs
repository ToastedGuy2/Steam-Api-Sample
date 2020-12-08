using System;
using System.Collections.Generic;
using System.Linq;
using Steam.Entities;
using Steam.Repositories.Generic;

namespace Steam.Repositories
{
    public class PublisherRepository : GenericRepository<Publisher>, IPublisherRepository
    {
        public PublisherRepository(SteamDbContext context) : base(context)
        {
        }
        public bool DoesPublisherExist(Guid publisherId)
        {
            if (publisherId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(publisherId));
            }
            return table.Any(p => p.PublisherId == publisherId);
        }

        public IEnumerable<Publisher> GetPublishersFiltered(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                return table.OrderBy(p => p.Name);
            }
            var filteredPublishers = table.Where(p => p.Name.Contains(name));
            return filteredPublishers.OrderBy(p => p.Name);
        }
    }
}