namespace Accommodation.Application.UseCases.Rooms.Hendlers;

public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateRoomCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateRoomCommand request, CancellationToken cancellationToken)
    {
        Room room = new Room()
        {
            RoomNumber = request.RoomNumber,
            Status = request.Status,
            HotelId = request.HotelId,
            RoomTypeId = request.RoomTypeId,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
        };

        await  _context.Rooms.AddAsync(room);
        int result =  await _context.SaveChangesAsync();

        return result;
    }
}
