using Demo.Notifications.Api.Domain.Entities;
using Demo.Notifications.Api.Domain.Enums;
using Demo.Notifications.Api.Infra.Services;
using Microsoft.AspNetCore.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Demo.Notifications.Api.Controllers;

[ApiController]
[Route("api/notifications")]
public class NotificationsController : ControllerBase
{
    private readonly INotificationFactoryFacade _notificationFactoryFacade;

    public NotificationsController(INotificationFactoryFacade notificationFactoryFacade)
    {
        _notificationFactoryFacade = notificationFactoryFacade;
    }

    [HttpPost]
    public async  Task<IActionResult> Notify(NotificationInput notification){

        var notificationFacade = _notificationFactoryFacade.GetFacade(notification.Type);
        
        await notificationFacade.SendAsync(notification.Destination, notification.Content);
            
        return Accepted();
    }
}
