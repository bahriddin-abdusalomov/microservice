namespace Accommodation.Application.UseCases.Bookings.Commands;

public class CreateBookingCommand : IRequest<int>
{
    public decimal TotalPrice { get; set; }
    public DateTime CheckinDate { get; set; }
    public DateTime CheckoutDate { get; set; }
    public long GuestId { get; set; }
    public long RoomId { get; set; }
}
