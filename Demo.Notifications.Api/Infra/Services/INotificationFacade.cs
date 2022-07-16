namespace Demo.Notifications.Api.Infra.Services
{
    public interface INotificationFacade
    {
         Task SendAsync(string destination, string content);
    }
}