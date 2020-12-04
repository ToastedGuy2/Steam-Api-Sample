using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Steam.API.Models;
using Steam.Entities;
using Steam.Services.Generic;
namespace Steam.API.Controllers
{
    [Route("api/Publishers/{publisherId}/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGenericService<Publisher> genericService;
        private readonly IMapper autoMapper;

        public GamesController(IGenericService<Publisher> genericService, IMapper autoMapper)
        {
            this.genericService = genericService ?? throw new ArgumentNullException(nameof(genericService));
            this.autoMapper = autoMapper ?? throw new ArgumentNullException(nameof(autoMapper));
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<Publisher>> GetPublishers()
        {
            return new List<Publisher> { };
        }

        [HttpGet("{gameId}")]
        public ActionResult<Publisher> GetPublisherById(Guid gameId)
        {
            return null;
        }

        [HttpPost("")]
        public ActionResult<Publisher> PostPublisher(Publisher model)
        {
            return null;
        }

        [HttpPut("{gameId}")]
        public IActionResult PutPublisher(Guid gameId, Publisher model)
        {
            return NoContent();
        }

        [HttpDelete("{gameId}")]
        public ActionResult<Publisher> DeletePublisherById(Guid gameId)
        {
            return null;
        }
    }
}