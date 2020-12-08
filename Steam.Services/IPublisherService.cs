using System;
using System.Collections.Generic;
using Steam.Entities;
using Steam.Services.Generic;

namespace Steam.Services
{
    public interface IPublisherService : IGenericService<Publisher>
    {
        IEnumerable<Publisher> GetPublishersFiltered(string name);
        bool DoesPublisherExist(Guid publisherId);
    }
}