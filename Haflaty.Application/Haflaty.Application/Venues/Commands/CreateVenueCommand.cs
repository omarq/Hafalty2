using System;
using Haflaty.Application.Venues.Models;
using MediatR;

namespace Haflaty.Application.Venues.Commands
{
    public class CreateVenueCommand:IRequest<VenueDetailsModel>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LocationName { get; set; }
        public string LocationUrl { get; set; }
        public string Description { get; set; }

    }
}
