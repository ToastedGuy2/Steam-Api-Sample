using AutoMapper;
using Steam.API.Models;
using Steam.Entities;

namespace Steam.API.Profiles
{
    public class PublisherProfile : Profile
    {
        public PublisherProfile()
        {
            CreateMap<Publisher, PublisherDTO>();
            CreateMap<PublisherForCreationDTO, Publisher>();
        }
    }
}