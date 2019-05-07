using System.Threading;
using System.Threading.Tasks;
using Haflaty.Application.Interfaces;
using Haflaty.Application.Venues.Models;
using Haflaty.Domain.Entities;
using MediatR;

namespace Haflaty.Application.Venues.Commands
{
    public class CreateVenueCommandHandler:IRequestHandler<CreateVenueCommand,VenueDetailsModel>
    {

        // will have dependicy on dbcontxt and external services 
        private readonly IHafaltyDbContext _context;

        public CreateVenueCommandHandler(IHafaltyDbContext context)
        {
            _context = context;
        }


        public async Task<VenueDetailsModel>  Handle(CreateVenueCommand request, CancellationToken cancellationToken)
        {
            var entity = new Venue
            {
                Id = request.Id,
                Description = request.Description

            };

            await _context.Venus.AddAsync(entity, cancellationToken);
            throw new System.NotImplementedException();
        }
    }
}