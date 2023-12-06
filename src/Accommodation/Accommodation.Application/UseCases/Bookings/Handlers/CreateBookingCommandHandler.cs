namespace Accommodation.Application.UseCases.Bookings.Hendlers;

public class CreateBookingCommandHandler : IRequestHandler<CreateBookingCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateBookingCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
    {
        Booking booking = new Booking()
        {
           TotalPrice = request.TotalPrice,
           CheckinDate = request.CheckinDate,
           CheckoutDate = request.CheckoutDate,
           RoomId = request.RoomId,
           GuestId = request.GuestId,
           CreatedDate = DateTime.UtcNow,
        };

        await  _context.Bookings.AddAsync(booking);
        int result =  await _context.SaveChangesAsync();

        return result;
    }
}
