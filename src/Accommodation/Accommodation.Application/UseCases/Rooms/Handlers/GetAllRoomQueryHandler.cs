namespace Accommodation.Application.UseCases.Rooms.Handlers;
public class GetAllRoomQueryHandler : IRequestHandler<GetAllRoomQuery, List<Room>>
{
    private readonly IApplicationDbContext _context;

    public GetAllRoomQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Room>> Handle(GetAllRoomQuery request, CancellationToken cancellationToken)
    {
        var rooms = await _context.Rooms.ToListAsync();
        return rooms;
    }
}