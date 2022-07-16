using Serilog;

namespace Demo.Notifications.Api.Infra.Services
{
    public class SmsFacade : INotificationFacade
    {
        public Task SendAsync(string destination, string content)
        {
            Log.Information("SMS was sent to {destination}", destination);

            return Task.CompletedTask;
        }
    }
}