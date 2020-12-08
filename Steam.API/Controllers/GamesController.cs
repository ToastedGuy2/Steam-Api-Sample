using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Steam.API.Models;
using Steam.Entities;
using Steam.Entities.ResourcesParameters;
using Steam.Services;
using Steam.Services.Generic;
namespace Steam.API.Controllers
{
    [Route("api/Publishers/{publisherId}/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IPublisherService _publisherService;
        private readonly IGameService _gameService;
        private readonly IMapper _autoMapper;

        public GamesController(IPublisherService publisherService, IGameService gameService, IMapper autoMapper)
        {
            this._publisherService = publisherService ?? throw new ArgumentNullException(nameof(publisherService));
            this._gameService = gameService ?? throw new ArgumentNullException(nameof(gameService));
            this._autoMapper = autoMapper ?? throw new ArgumentNullException(nameof(autoMapper));
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<Game>> GetGames(Guid publisherId, [FromQuery] GameResourceParameters gameResourceParameters)
        {
            if (!_publisherService.DoesPublisherExist(publisherId))
            {
                return NotFound();
            }
            var gamesEntities = _gameService.GetGamesByPublisherId(publisherId, gameResourceParameters);
            var gamesDtos = _autoMapper.Map<IEnumerable<GameDTO>>(gamesEntities);
            return Ok(gamesDtos);
        }

        [HttpGet("{gameId}", Name = "GetGameById")]
        public ActionResult<Game> GetGameById(Guid publisherId, Guid gameId)
        {
            if (!_publisherService.DoesPublisherExist(publisherId))
            {
                return NotFound();
            }
            var gameEntitie = _gameService.GetById(gameId);
            if (gameEntitie == null)
            {
                return NotFound();
            }
            var gameDto = _autoMapper.Map<GameDTO>(gameEntitie);
            return Ok(gameDto);
        }

        [HttpPost("")]
        public ActionResult<GameDTO> PostGame(GameForCreationDTO model, Guid publisherId)
        {
            if (!_publisherService.DoesPublisherExist(publisherId))
            {
                return NotFound();
            }

            var gameEntitie = _autoMapper.Map<Game>(model);
            _gameService.Insert(gameEntitie);
            _gameService.Save();
            var gameDto = _autoMapper.Map<GameDTO>(gameEntitie);
            return CreatedAtRoute("GetGameById", new { publisherId = publisherId, gameId = gameDto.GameId }, gameDto);
        }

        [HttpPut("{gameId}")]
        public IActionResult PutGame(Guid gameId, Game model)
        {
            return NoContent();
        }

        [HttpDelete("{gameId}")]
        public ActionResult<Game> DeleteGameById(Guid gameId)
        {
            return null;
        }
    }
}