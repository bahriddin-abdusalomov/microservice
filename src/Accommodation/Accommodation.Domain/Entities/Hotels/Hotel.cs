namespace Accommodation.Domain.Entities.Hotels;

public class Hotel : BaseEntity
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public int Stars { get; set; }
    public string ImagePath { get; set; }

    #region relations

    public long StaffId { get; set; }
    public ICollection<Staff> Staffs { get; set; }

    public long RoomId { get; set; }
    public ICollection<Room> Rooms { get; set; }

    #endregion

}
