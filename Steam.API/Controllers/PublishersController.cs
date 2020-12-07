using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Steam.Entities;
using Steam.API.Models;
using Steam.Services.Generic;
using AutoMapper;
using Steam.Services;

namespace Steam.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private readonly IPublisherService _publisherService;
        private readonly IMapper _autoMapper;

        public PublishersController(IPublisherService publisherService, IMapper autoMapper)
        {
            this._publisherService = publisherService ?? throw new ArgumentNullException(nameof(publisherService));
            this._autoMapper = autoMapper ?? throw new ArgumentNullException(nameof(autoMapper));
        }

        [HttpGet("")]
        [HttpHead]
        public ActionResult<IEnumerable<Publisher>> GetPublishers(string name)
        {
            var publisherEntities = _publisherService.GetPublishersFiltered(name);
            var publisherDtos = _autoMapper.Map<IEnumerable<PublisherDTO>>(publisherEntities);
            return Ok(publisherDtos);
        }

        [HttpGet("{id}", Name = "GetPublisherById")]
        public ActionResult<Publisher> GetPublisherById(Guid id)
        {
            var publisherEntitie = _publisherService.GetById(id);
            if (publisherEntitie == null)
            {
                return NotFound();
            }
            var publisherDto = _autoMapper.Map<PublisherDTO>(publisherEntitie);
            return Ok(publisherDto);
        }

        // [HttpPost("")]
        // public ActionResult<PublisherDTO> PostPublisher(PublisherForCreationDTO model)
        // {
        //     var publisherEntitie = _autoMapper.Map<Publisher>(model);
        //     _publisherService.Insert(publisherEntitie);
        //     _publisherService.Save();
        //     var publisherResponse = _autoMapper.Map<PublisherDTO>(publisherEntitie);
        //     return CreatedAtRoute("GetPublisherById", new { id = publisherResponse.PublisherId }, publisherResponse);
        // }

        [HttpPost("")]
        public ActionResult<PublisherDTO> PostPublisher(PublisherForCreationDTO model)
        {
            var publisherEntitie = _autoMapper.Map<Publisher>(model);
            _publisherService.Insert(publisherEntitie);
            _publisherService.Save();
            var publisherResponse = _autoMapper.Map<PublisherDTO>(publisherEntitie);
            return CreatedAtRoute("GetPublisherById", new { id = publisherResponse.PublisherId }, publisherResponse);
        }

        [HttpPut("{id}")]
        public IActionResult PutPublisher(int id, Publisher model)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Publisher> DeletePublisherById(int id)
        {
            return null;
        }
        [HttpOptions("")]
        public IActionResult GetPublisherOptions()
        {
            Response.Headers.Add("Add", "GET,HEAD,POST");
            return Ok();
        }

    }
}