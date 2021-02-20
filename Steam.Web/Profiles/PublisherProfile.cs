using AutoMapper;
using Steam.Entities;
using Steam.Web.Models;

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