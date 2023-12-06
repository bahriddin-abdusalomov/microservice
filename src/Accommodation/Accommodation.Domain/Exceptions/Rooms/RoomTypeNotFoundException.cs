namespace Accommodation.Domain.Exceptions.Rooms;

public class RoomTypeNotFoundException : NotFoundException
{
    public RoomTypeNotFoundException()
    {
        Message = "Room type not found !";
    }
}
