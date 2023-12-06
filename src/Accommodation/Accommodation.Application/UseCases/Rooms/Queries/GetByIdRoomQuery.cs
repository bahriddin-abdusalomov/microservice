namespace Accommodation.Application.UseCases.Rooms.Queries;

public class GetByIdRoomQuery : IRequest<Room>
{
    public long Id { get; set; }
}

