using Accommodation.Application.UseCases.Rooms.Commands;
using Accommodation.Application.UseCases.Rooms.Queries;
using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace Accommodation.Presentation.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class RoomsController : ControllerBase
{
    private readonly IMediator _mediator;

    public RoomsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async ValueTask<IActionResult> CreateRoomAsync([FromForm] CreateRoomCommand command)
    {
        int result = await _mediator.Send(command);
        return Ok(result);
    }


    [HttpGet]
    public async ValueTask<IActionResult> GetByIdRoomAsync(long id)
    {
        var command = new GetByIdRoomQuery { Id = id };
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllRoomAsync()
    {
        var result = await _mediator.Send(new GetAllRoomQuery());
        return Ok(result);
    }

    [HttpPut]
    public async ValueTask<IActionResult> UpdateRoomAsync([FromForm] UpdateRoomCommand command)
    {
        int result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete]
    public async ValueTask<IActionResult> DeleteRoomAsync(long id)
    {
        var command = new DeleteRoomCommand { Id = id };

        int result = await _mediator.Send(command);
        return Ok(result);
    }
}
