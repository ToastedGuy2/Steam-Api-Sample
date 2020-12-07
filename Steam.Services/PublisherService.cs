using System;
using System.Collections.Generic;
using Steam.Entities;
using Steam.Repositories;
using Steam.Repositories.Generic;
using Steam.Services.Generic;

namespace Steam.Services
{
    public class PublisherService : GenericService<Publisher>, IPublisherService
    {
        private readonly IPublisherRepository _publisherRepository;

        public PublisherService(IGenericRepository<Publisher> genericRepository, IPublisherRepository publisherRepository) : base(genericRepository)
        {
            this._publisherRepository = publisherRepository;
        }

        public bool DoesPublisherExist(Guid publisherId)
        {
            return _publisherRepository.DoesPublisherExist(publisherId);
        }

        public IEnumerable<Publisher> GetPublishersFiltered(string name)
        {
            return _publisherRepository.GetPublishersFiltered(name);
        }
    }
}