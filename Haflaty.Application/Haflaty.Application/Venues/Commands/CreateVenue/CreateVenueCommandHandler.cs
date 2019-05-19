using System.Threading;
using System.Threading.Tasks;
using Haflaty.Application.Interfaces;
using Haflaty.Application.Venues.Commands.CreateVenue;
using Haflaty.Application.Venues.Models;
using Haflaty.Domain.Entities;
using MediatR;

namespace Haflaty.Application.Venues.Commands.CreateVenue
{
    public class CreateVenueCommandHandler : IRequestHandler<CreateVenueCommand, Unit>
    {

        // will have dependicy on dbcontxt and external services 
        private readonly IHafaltyDbContext _context;
        private readonly IMediator _mediator;

        public CreateVenueCommandHandler(IHafaltyDbContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<Unit> Handle(CreateVenueCommand request, CancellationToken cancellationToken)
        {
            var entity = new Venue
            {
                Id = request.Id,
                Description = request.Description

            };

            await _context.Venus.AddAsync(entity, cancellationToken);
            await _mediator.Publish(new VenuCreated { Id = entity.Id }, cancellationToken);

            return Unit.Value;
        }
    }
}