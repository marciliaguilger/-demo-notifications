namespace Demo.Notifications.Api.Infra.Services
{
    public interface IEmailFacade
    {
        Task SendAsync(string destination, string content);
    }
}  