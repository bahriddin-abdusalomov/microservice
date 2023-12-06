namespace Accommodation.Application.UseCases.RoomTypes.Handlers;

public class GetByIdRoomTypeQueryHandler : IRequestHandler<GetByIdRoomTypeQuery, RoomType>
{
    private readonly IApplicationDbContext _context;

    public GetByIdRoomTypeQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<RoomType> Handle(GetByIdRoomTypeQuery request, CancellationToken cancellationToken)
    {
        var roomType = await _context.RoomTypes.FindAsync(request.Id);
        if (roomType == null) throw new RoomTypeNotFoundException();

        return roomType;
    }
}
