namespace Accommodation.Domain.Exceptions.Rooms;

public class RoomNotFoundException : NotFoundException
{
    public RoomNotFoundException()
    {
        Message = "Room not found !";
    }
}
