using System;
using System.Collections.Generic;
using Steam.Entities;
using Steam.Repositories.Generic;

namespace Steam.Repositories
{
    public interface IPublisherRepository : IGenericRepository<Publisher>
    {
        IEnumerable<Publisher> GetPublishersFiltered(string name);
        bool DoesPublisherExist(Guid publisherId);

    }
}