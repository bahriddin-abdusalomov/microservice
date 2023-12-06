namespace Accommodation.Domain.Exceptions.Bookings;

public class BookingNotFoundException : NotFoundException
{
    public BookingNotFoundException()
    {
        Message = "Booking not found !";
    }
}
