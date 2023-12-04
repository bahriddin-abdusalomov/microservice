using Accommodation.Domain.Entities.Bookings;
using Accommodation.Domain.Entities.Hotels;
using Accommodation.Domain.Enums.Status;

namespace Accommodation.Domain.Entities.Rooms;

public class Room : BaseEntity
{
    public int RoomNumber { get; set; }
    public RoomStatus Status { get; set; }

    #region relations

    public long HotelId { get; set; }
    public Hotel Hotel { get; set; }

    public long RoomTypeId { get; set; }
    public RoomType RoomType { get; set; }

    public Booking Booking { get; set; }
    #endregion
}
