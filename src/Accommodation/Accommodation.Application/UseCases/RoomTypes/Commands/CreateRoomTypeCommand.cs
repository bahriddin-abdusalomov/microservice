namespace Accommodation.Application.UseCases.RoomTypes.Commands;

public class CreateRoomTypeCommand : IRequest<int>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public long RoomId { get; set; }
}
