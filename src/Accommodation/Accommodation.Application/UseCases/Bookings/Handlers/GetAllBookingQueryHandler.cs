namespace Accommodation.Application.UseCases.Bookings.Handlers;

public class GetAllBookingQueryHandler : IRequestHandler<GetAllBookingQuery, List<Booking>>
{
    private readonly IApplicationDbContext _context;

    public GetAllBookingQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Booking>> Handle(GetAllBookingQuery request, CancellationToken cancellationToken)
    {
        var bookings = await _context.Bookings.ToListAsync();
        return bookings;
    }
}