using System.Collections.Generic;
using Steam.Entities;
using Steam.Repositories;
using Steam.Repositories.Generic;
using Steam.Services.Generic;

namespace Steam.Services
{
    public class PublisherService : GenericService<Publisher>, IPublisherService
    {
        private readonly IPublisherRepository publisherRepository;

        public PublisherService(IGenericRepository<Publisher> genericRepository, IPublisherRepository publisherRepository) : base(genericRepository)
        {
            this.publisherRepository = publisherRepository;
        }

        public IEnumerable<Publisher> GetPublishersFiltered(string name)
        {
            return publisherRepository.GetPublishersFiltered(name);
        }
    }
}