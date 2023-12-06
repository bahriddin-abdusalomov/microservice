namespace Accommodation.Presentation.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class BookingsController : ControllerBase
{
    private readonly IMediator _mediator;

    public BookingsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async ValueTask<IActionResult> CreateBookingAsync([FromForm] CreateBookingCommand command)
    {
        int result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async ValueTask<IActionResult> GetByIdBookingAsync(long id)
    {
        var command = new GetByIdBookingQuery { Id = id };
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllBookingAsync()
    {
        var result = await _mediator.Send(new GetAllBookingQuery());
        return Ok(result);
    }

    [HttpPut]
    public async ValueTask<IActionResult> UpdateBookingAsync([FromForm] UpdateBookingCommand command)
    {
        int result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete]
    public async ValueTask<IActionResult> DeleteBookingAsync(long id)
    {
        var command = new DeleteBookingCommand { Id = id };

        int result = await _mediator.Send(command);
        return Ok(result);
    }
}
