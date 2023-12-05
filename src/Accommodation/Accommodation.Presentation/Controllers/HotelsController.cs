using Accommodation.Application.UseCases.Hotels.Commands;
using Accommodation.Application.UseCases.Hotels.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Accommodation.Presentation.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class HotelsController : ControllerBase
{
    private readonly IMediator _mediator;

    public HotelsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async ValueTask<IActionResult> CreateHotelAsync([FromForm] CreateHotelCommand command)
    {
        int result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async ValueTask<IActionResult> GetByIdHotelAsync(long id)
    {
        var command = new GetByIdHotelQuery { Id = id };
        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllHotelAsync()
    {
        var result = await _mediator.Send(new GetAllHotelQuery());
        return Ok(result);
    }

    [HttpPut]
    public async ValueTask<IActionResult> UpdateHotelAsync([FromForm] UpdateHotelCommand command)
    {
        int result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete]
    public async ValueTask<IActionResult> DeleteHotelAsync(long id)
    {
        var command = new DeleteHotelCommand { Id = id };

        int result =  await _mediator.Send(command);
        return Ok(result);
    }

}
