
namespace Demo.Notifications.Api.Aplication
{
    public interface IMediator
    {
         Task<object> Send (ICommand command);
    }
}