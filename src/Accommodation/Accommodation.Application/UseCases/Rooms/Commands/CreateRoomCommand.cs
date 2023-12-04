namespace Accommodation.Application.UseCases.Rooms.Commands;

public class CreateRoomCommand : IRequest
{
    public int RoomNumber { get; set; }
    public RoomStatus Status { get; set; }
    public long HotelId { get; set; }
    public long RoomTypeId { get; set; }

}
