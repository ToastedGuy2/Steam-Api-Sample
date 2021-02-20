using AutoMapper;
using Steam.Entities;
using Steam.Web.Models;

namespace Steam.API.Profiles
{
    public class GameProfile : Profile
    {
        public GameProfile()
        {
            CreateMap<Game, GameDTO>();
            CreateMap<GameForCreationDTO, Game>();
        }
    }
}