using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Steam.Entities;
using Steam.Services;
using Steam.Web.Models;
//using Steam.API.Models;

namespace Steam.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherCollectionsController : ControllerBase
    {
        private readonly IPublisherService _publisherService;
        private readonly IMapper _autoMapper;

        public PublisherCollectionsController(IPublisherService publisherService, IMapper autoMapper)
        {
            this._publisherService = publisherService ?? throw new ArgumentNullException(nameof(publisherService));
            this._autoMapper = autoMapper ?? throw new ArgumentNullException(nameof(autoMapper));
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<PublisherDTO>> GetPublisherDTOs()
        {
            return new List<PublisherDTO> { };
        }

        // [HttpGet("{id}")]
        // public ActionResult<PublisherDTO> GetPublisherDTOById(int id)
        // {
        //     return null;
        // }

        [HttpPost("")]
        public ActionResult<IEnumerable<PublisherForCreationDTO>> PostPublisherDTO(IEnumerable<PublisherForCreationDTO> model)
        {
            var publisherEntities = _autoMapper.Map<IEnumerable<Publisher>>(model);
            foreach (var publisher in publisherEntities)
            {
                _publisherService.Insert(publisher);
            }
            _publisherService.Save();
            var publisherDtos = _autoMapper.Map<IEnumerable<PublisherDTO>>(publisherEntities);
            return Ok(publisherDtos);
        }

        // [HttpPut("{id}")]
        // public IActionResult PutPublisherDTO(int id, PublisherDTO model)
        // {
        //     return NoContent();
        // }

        // [HttpDelete("{id}")]
        // public ActionResult<PublisherDTO> DeletePublisherDTOById(int id)
        // {
        //     return null;
        // }
    }
}