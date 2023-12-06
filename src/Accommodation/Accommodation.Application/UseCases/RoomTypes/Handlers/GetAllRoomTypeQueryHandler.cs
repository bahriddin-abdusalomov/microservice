namespace Accommodation.Application.UseCases.RoomTypes.Handlers;

public class GetAllRoomTypeQueryHandler : IRequestHandler<GetAllRoomTypeQuery, List<RoomType>>
{
    private readonly IApplicationDbContext _context;

    public GetAllRoomTypeQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<RoomType>> Handle(GetAllRoomTypeQuery request, CancellationToken cancellationToken)
    {
        var RoomTypes = await _context.RoomTypes.ToListAsync();
        return RoomTypes;
    }
}