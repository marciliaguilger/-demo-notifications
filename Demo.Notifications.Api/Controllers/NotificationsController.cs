using Demo.Notifications.Api.Aplication;
using Demo.Notifications.Api.Aplication.NotifyUser;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Notifications.Api.Controllers;

[ApiController]
[Route("api/notifications")]
public class NotificationsController : ControllerBase
{
    private readonly IMediator _mediator;

    public NotificationsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async  Task<IActionResult> Notify(NotifyUserCommand command){

        await _mediator.Send(command);
            
        return Accepted();
    }

    [HttpGet("{userId}")]
    public async Task<IActionResult> GetNotificationsForUser(){
        return Ok();
    }
}
