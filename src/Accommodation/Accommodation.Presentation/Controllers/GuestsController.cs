namespace Accommodation.Presentation.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class GuestsController : ControllerBase
{
    private readonly IMediator _mediator;

    public GuestsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async ValueTask<IActionResult> CreateGuestAsync([FromForm] CreateGuestCommand command)
    {
        int result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async ValueTask<IActionResult> GetByIdGuestAsync(long id)
    {
        var command = new GetByIdGuestQuery { Id = id };
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllGuestAsync()
    {
        var result = await _mediator.Send(new GetAllGuestQuery());
        return Ok(result);
    }

    [HttpPut]
    public async ValueTask<IActionResult> UpdateGuestAsync([FromForm] UpdateGuestCommand command)
    {
        int result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete]
    public async ValueTask<IActionResult> DeleteGuestAsync(long id)
    {
        var command = new DeleteGuestCommand { Id = id };

        int result = await _mediator.Send(command);
        return Ok(result);
    }
}
