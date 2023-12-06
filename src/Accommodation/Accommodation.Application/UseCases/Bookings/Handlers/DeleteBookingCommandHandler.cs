using Accommodation.Application.UseCases.Bookings.Commands;
using Accommodation.Domain.Exceptions.Bookings;

namespace Accommodation.Application.UseCases.Bookings.Handlers;

public class DeleteBookingCommandHandler : IRequestHandler<DeleteBookingCommand, int>
{
    private readonly IApplicationDbContext _context;

    public DeleteBookingCommandHandler(IApplicationDbContext context, IFileService fileService)
    {
        _context = context;
    }

    public async Task<int> Handle(DeleteBookingCommand request, CancellationToken cancellationToken)
    {
        Booking booking = await _context.Bookings.FirstAsync(booking => booking.Id == request.Id);
        if (booking == null) throw new BookingNotFoundException();

        _context.Bookings.Remove(booking);
        int resutlt = await _context.SaveChangesAsync(cancellationToken);

        return resutlt;
    }
}
