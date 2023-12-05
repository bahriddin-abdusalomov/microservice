using Accommodation.Application.UseCases.Rooms.Queries;
using Accommodation.Domain.Exceptions.Rooms;

namespace Accommodation.Application.UseCases.Rooms.Handlers;
public class GetByIdRoomQueryHandler : IRequestHandler<GetByIdRoomQuery, Room>
{
    private readonly IApplicationDbContext _context;

    public GetByIdRoomQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Room> Handle(GetByIdRoomQuery request, CancellationToken cancellationToken)
    {
        var room = await _context.Rooms.FindAsync(request.Id);
        if (room == null) throw new RoomNotFoundException();

        return room;
    }
}
