namespace Accommodation.Presentation.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class RoomTypesController : ControllerBase
{
    private readonly IMediator _mediator;

    public RoomTypesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async ValueTask<IActionResult> CreateRoomTypeAsync([FromForm] CreateRoomTypeCommand command)
    {
        int result = await _mediator.Send(command);
        return Ok(result);
    }


    [HttpGet]
    public async ValueTask<IActionResult> GetByIdRoomTypeAsync(long id)
    {
        var command = new GetByIdRoomTypeQuery { Id = id };
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllRoomTypeAsync()
    {
        var result = await _mediator.Send(new GetAllRoomTypeQuery());
        return Ok(result);
    }

    [HttpPut]
    public async ValueTask<IActionResult> UpdateRoomTypeAsync([FromForm] UpdateRoomTypeCommand command)
    {
        int result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete]
    public async ValueTask<IActionResult> DeleteRoomTypeAsync(long id)
    {
        var command = new DeleteRoomTypeCommand { Id = id };

        int result = await _mediator.Send(command);
        return Ok(result);
    }
}
