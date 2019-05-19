using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Haflaty.Application.Venues.Commands.CreateVenue;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Haflaty.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class VenueController : ControllerBase
    {
        private Mediator _mediator;

        public VenueController(Mediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> AddVenue([FromBody] CreateVenueCommand createVenueCommand)
        {
            var commandResult = await _mediator.Send(createVenueCommand);

            return Ok(commandResult);


        }
    }
}