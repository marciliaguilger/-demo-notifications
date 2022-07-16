using Demo.Notifications.Api.Domain.Enums;
using SendGrid;

namespace Demo.Notifications.Api.Infra.Services
{
    public class NotificationFactoryFacade : INotificationFactoryFacade
    {
        private readonly ISendGridClient _sendGridclient;

        public NotificationFactoryFacade(ISendGridClient sendGridclient)
        {
            _sendGridclient = sendGridclient;
        }
        
        public INotificationFacade GetFacade(NotificationType type)
        {
            if (type == NotificationType.Email)
                return new EmailFacade(_sendGridclient);

            return new SmsFacade();

        }
    }
}