namespace Accommodation.Domain.Entities.Guests;

public class Guest : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string ImagePath { get; set; }

    #region relations

    public long BookingId { get; set; }
    public ICollection<Booking> Bookings { get; set; }

    #endregion
}
