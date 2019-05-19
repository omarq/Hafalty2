using Haflaty.Application.Notifications.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Haflaty.Application.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(Message message);

    }
}
