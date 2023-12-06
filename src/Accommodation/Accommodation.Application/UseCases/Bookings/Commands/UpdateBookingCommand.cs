namespace Accommodation.Application.UseCases.Bookings.Commands;

public class UpdateBookingCommand : IRequest<int>
{
    public long Id { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime CheckinDate { get; set; }
    public DateTime CheckoutDate { get; set; }
    public long GuestId { get; set; }
    public long RoomId { get; set; }
}
