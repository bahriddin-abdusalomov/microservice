namespace Accommodation.Application.UseCases.Rooms.Handlers;

public class CreateRoomCommandHandler : AsyncRequestHandler<CreateRoomCommand>
{
    private readonly IApplicationDbContext _context;

    public CreateRoomCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    protected override async Task Handle(CreateRoomCommand request, CancellationToken cancellationToken)
    {
        Room room = new Room()
        {
            RoomNumber = request.RoomNumber,
            Status = request.Status,
            RoomTypeId = request.RoomTypeId,
            HotelId = request.HotelId,
        };

        await _context.Rooms.AddAsync(room);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
