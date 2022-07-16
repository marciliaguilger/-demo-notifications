using Demo.Notifications.Api.Domain.Enums;
using MediatR;

namespace Demo.Notifications.Api.Aplication.NotifyUser
{
    public class NotifyUserCommand : IRequest
    {
        public string Destination { get; set; }
        public string Content { get; set; }
        public NotificationType Type { get; set; }
    }
}