namespace Accommodation.Presentation.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class StaffsController : ControllerBase
{
    private readonly IMediator _mediator;

    public StaffsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async ValueTask<IActionResult> CreateStaffAsync([FromForm] CreateStaffCommand command)
    {
        int result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async ValueTask<IActionResult> GetByIdStaffAsync(long id)
    {
        var command = new GetByIdStaffQuery { Id = id };
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllStaffAsync()
    {
        var result = await _mediator.Send(new GetAllStaffQuery());
        return Ok(result);
    }

    [HttpPut]
    public async ValueTask<IActionResult> UpdateStaffAsync([FromForm] UpdateStaffCommand command)
    {
        int result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete]
    public async ValueTask<IActionResult> DeleteStaffAsync(long id)
    {
        var command = new DeleteStaffCommand { Id = id };

        int result = await _mediator.Send(command);
        return Ok(result);
    }
}
