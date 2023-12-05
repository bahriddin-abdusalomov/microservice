namespace Accommodation.Application.UseCases.Rooms.Commands;

public class UpdateRoomCommand : IRequest<int>
{
    public int Id { get; set; }
    public int RoomNumber { get; set; }
    public RoomStatus Status { get; set; }
    public long HotelId { get; set; }
    public long RoomTypeId { get; set; }
}
