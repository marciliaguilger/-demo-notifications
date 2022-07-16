using Demo.Notifications.Api.Domain.Enums;

namespace Demo.Notifications.Api.Infra.Services
{
    public interface INotificationFactoryFacade
    {
         INotificationFacade GetFacade(NotificationType type);
    }
}