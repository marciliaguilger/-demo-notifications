using Demo.Notifications.Api.Domain.Entities;
using Demo.Notifications.Api.Infra.Services;
using Microsoft.AspNetCore.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Demo.Notifications.Api.Controllers;

[ApiController]
[Route("api/notifications")]
public class NotificationsController : ControllerBase
{
    private readonly ILogger<NotificationsController> _logger;
    private readonly IEmailFacade _emailFacade;

    public NotificationsController(ILogger<NotificationsController> logger, IEmailFacade emailFacade)
    {
        _logger = logger;
        _emailFacade = emailFacade;
    }

    [HttpPost]
    public async  Task<IActionResult> Notify(NotificationInput notification){

        await _emailFacade.SendAsync(notification.Destination, notification.Content);

        return Accepted();
    }
}
