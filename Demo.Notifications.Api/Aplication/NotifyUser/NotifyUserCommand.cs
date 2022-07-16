using Demo.Notifications.Api.Domain.Enums;

namespace Demo.Notifications.Api.Aplication.NotifyUser
{
    public class NotifyUserCommand : ICommand
    {
        public string Destination { get; set; }
        public string Content { get; set; }
        public NotificationType Type { get; set; }
    }
}