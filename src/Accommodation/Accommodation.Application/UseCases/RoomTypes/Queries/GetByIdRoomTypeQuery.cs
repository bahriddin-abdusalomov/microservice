namespace Accommodation.Application.UseCases.RoomTypes.Queries;

public class GetByIdRoomTypeQuery : IRequest<RoomType>
{
    public long Id { get; set; }
}

