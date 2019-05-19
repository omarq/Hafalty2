using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;


namespace Haflaty.Application.Venues.Commands.CreateVenue
{
    public class CreateVenueCommandValidator : AbstractValidator<CreateVenueCommand>
    {

        public CreateVenueCommandValidator( )
        {

            RuleFor(c => c.Id).NotEmpty();


        }



    }
}
