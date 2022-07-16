using Demo.Notifications.Api.Infra.Services;

namespace Demo.Notifications.Api.Aplication.NotifyUser
{
    public class NotifyUserCommandHandler : ICommandHandler<NotifyUserCommand, Task>
    {
        private readonly INotificationFactoryFacade _factoryFacade;

        public NotifyUserCommandHandler(INotificationFactoryFacade factoryFacade)
        {
            _factoryFacade = factoryFacade;
        }

        public async Task Handle(NotifyUserCommand command)
        {
            var notificationService = _factoryFacade.GetFacade(command.Type);
            await notificationService.SendAsync(command.Destination, command.Content);
        }
    }
}