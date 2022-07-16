using Demo.Notifications.Api.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Demo.Notifications.Api.Controllers;

[ApiController]
[Route("api/notifications")]
public class NotificationsController : ControllerBase
{
    private readonly ILogger<NotificationsController> _logger;
    private readonly ISendGridClient _sendGridClient;

    public NotificationsController(ILogger<NotificationsController> logger, ISendGridClient sendGridClient)
    {
        _logger = logger;
        _sendGridClient = sendGridClient;
    }

    [HttpPost]
    public async  Task<IActionResult> Notify(NotificationInput notification){

        var message = new SendGridMessage{
            From = new EmailAddress("teste@gmail.com","Marci"),
            Subject = "Testing e-mail POC",
            PlainTextContent = $"Hello! {notification.Content}"

        };

        message.AddTo(notification.Destination, notification.Destination);
        await _sendGridClient.SendEmailAsync(message);

        return Accepted();
    }

    
}
