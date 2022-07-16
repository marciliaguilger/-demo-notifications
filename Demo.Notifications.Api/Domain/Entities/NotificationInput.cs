using Demo.Notifications.Api.Domain.Enums;

namespace Demo.Notifications.Api.Domain.Entities
{
    public class NotificationInput
    {
        public string Destination { get; set; }
        public string Content { get; set; }
        public NotificationType Type { get; set; }
    }
}