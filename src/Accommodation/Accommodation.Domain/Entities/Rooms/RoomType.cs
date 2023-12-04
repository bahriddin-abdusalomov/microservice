using Accommodation.Domain.Entities.Staffs;

namespace Accommodation.Domain.Entities.Rooms;

public class RoomType : BaseEntity  
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    #region relations

    public long RoomId { get; set; }
    public ICollection<Room> Rooms { get; set; }

    #endregion
}
