namespace Accommodation.Application.UseCases.Rooms.Commands;

public class DeleteRoomCommand : IRequest<int>
{
    public long Id { get; set; }
}
