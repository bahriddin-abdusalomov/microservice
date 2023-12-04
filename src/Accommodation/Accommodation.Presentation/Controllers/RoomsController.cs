using Accommodation.Application.UseCases.Rooms.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Accommodation.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoomsController : ControllerBase
{
    private readonly IMediator _mediator;

    public RoomsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async ValueTask<IActionResult> CreateAsync(CreateRoomCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }
}
