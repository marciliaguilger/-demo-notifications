using Newtonsoft.Json;
using Serilog;

namespace Demo.Notifications.Api.Aplication.NotifyUser
{
    public class NotifyUserCommandHandlerWithLog : ICommandHandler<NotifyUserCommand, Task>
    {
        private readonly NotifyUserCommandHandler _handler;

        public NotifyUserCommandHandlerWithLog(NotifyUserCommandHandler handler)
        {
            _handler = handler;
        }

        public async Task Handle(NotifyUserCommand command)
        {
            Log.Information("Command {command} was handled with data {data}",command.GetType().Name, JsonConvert.SerializeObject(command)) ;
            
            await _handler.Handle(command);
        }
    }
}