using MediatR.Pipeline;
using Newtonsoft.Json;
using Serilog;

namespace Demo.Notifications.Api.Aplication.NotifyUser
{
    public class NotifyUserCommandHandlerWithLog : IRequestPreProcessor<NotifyUserCommand>
    {
        public Task Process(NotifyUserCommand request, CancellationToken cancellationToken)
        {
            Log.Information("Command {command} was handled with data {data}", request.GetType().Name, JsonConvert.SerializeObject(request)) ;

            return Task.CompletedTask;
        }
    }
}