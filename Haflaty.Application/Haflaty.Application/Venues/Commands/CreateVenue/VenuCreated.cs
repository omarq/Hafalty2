using Haflaty.Application.Interfaces;
using Haflaty.Application.Notifications.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Haflaty.Application.Venues.Commands.CreateVenue
{
    public class VenuCreated :INotification
    {
        public Guid Id { get; set; }

        public class VenuCreatedHandler : INotificationHandler<VenuCreated>
        {
            private readonly INotificationService _notification;

            public VenuCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(VenuCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message());
            }
        }
    }
}
