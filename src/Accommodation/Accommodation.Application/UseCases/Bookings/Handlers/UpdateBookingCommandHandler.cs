namespace Accommodation.Application.UseCases.Bookings.Handlers;

public class UpdateBookingCommandHandler : IRequestHandler<UpdateBookingCommand, int>
{
    private readonly IApplicationDbContext _context;

    public UpdateBookingCommandHandler(IApplicationDbContext context, IFileService fileService)
    {
        _context = context;
    }

    public async Task<int> Handle(UpdateBookingCommand request, CancellationToken cancellationToken)
    {
        Booking? booking = await _context.Bookings.FirstOrDefaultAsync(booking => booking.Id == request.Id);
        if (booking == null) throw new BookingNotFoundException();


        booking.TotalPrice = request.TotalPrice;
        booking.CheckoutDate = request.CheckoutDate;
        booking.CheckinDate = request.CheckinDate;
        booking.RoomId = request.RoomId;
        booking.GuestId = request.GuestId;
        booking.UpdatedDate = DateTime.UtcNow;

        _context.Bookings.Update(booking);
        int result = await _context.SaveChangesAsync();
        return result;
    }
}

