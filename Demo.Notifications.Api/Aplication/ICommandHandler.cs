using Demo.Notifications.Api.Aplication.NotifyUser;

namespace Demo.Notifications.Api.Aplication
{
    public interface ICommandHandler<T,U> where T: ICommand
    {
         U Handle(T command);
    }
}