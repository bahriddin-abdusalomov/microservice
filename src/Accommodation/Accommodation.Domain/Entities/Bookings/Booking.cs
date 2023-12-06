namespace Accommodation.Domain.Entities.Bookings;

public class Booking : BaseEntity
{
    public decimal TotalPrice { get; set; }
    public DateTime CheckinDate { get; set; }
    public DateTime CheckoutDate { get; set; }

    #region relations

    public long GuestId { get; set; }
    public Guest Guest { get; set; }

    public long RoomId { get; set; }    
    public Room Room { get; set; } 
    
    #endregion
}

