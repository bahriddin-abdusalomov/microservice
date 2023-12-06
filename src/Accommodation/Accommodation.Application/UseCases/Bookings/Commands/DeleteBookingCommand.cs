namespace Accommodation.Application.UseCases.Bookings.Commands;

public class DeleteBookingCommand : IRequest<int>
{
    public long Id { get; set; }
}
