using AutoMapper;
using Steam.API.Models;
using Steam.Entities;

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