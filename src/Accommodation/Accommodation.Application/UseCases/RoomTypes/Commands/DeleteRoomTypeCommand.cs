namespace Accommodation.Application.UseCases.RoomTypes.Commands;

public class DeleteRoomTypeCommand : IRequest<int>
{
    public long Id { get; set; }
}
