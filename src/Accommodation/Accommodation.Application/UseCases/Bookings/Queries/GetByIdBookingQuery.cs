namespace Accommodation.Application.UseCases.Bookings.Queries;

public class GetByIdBookingQuery : IRequest<Booking>
{
    public long Id { get; set; }
}

