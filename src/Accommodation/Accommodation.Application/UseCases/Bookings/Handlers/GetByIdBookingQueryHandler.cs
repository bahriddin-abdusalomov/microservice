namespace Accommodation.Application.UseCases.Bookings.Handlers;

public class GetByIdBookingQueryHandler : IRequestHandler<GetByIdBookingQuery, Booking>
{
    private readonly IApplicationDbContext _context;

    public GetByIdBookingQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Booking> Handle(GetByIdBookingQuery request, CancellationToken cancellationToken)
    {
        var booking = await _context.Bookings.FindAsync(request.Id);
        if (booking == null) throw new BookingNotFoundException();

        return booking;
    }
}
