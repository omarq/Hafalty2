using System;
using MediatR;

namespace Haflaty.Application.Venues.Commands.CreateVenue
{
    public class CreateVenueCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LocationName { get; set; }
        public string LocationUrl { get; set; }
        public string Description { get; set; }
        
    }
}
