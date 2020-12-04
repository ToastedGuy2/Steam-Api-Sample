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

        public IEnumerable<Publisher> GetPublishersFiltered(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                return GetAll();
            }
            var filteredPublishers = table.Where(p => p.Name.Contains(name));
            return filteredPublishers;
        }
    }
}