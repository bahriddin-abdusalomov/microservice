namespace Accommodation.Application.UseCases.Rooms.Handlers;

public class UpdateRoomCommandHandler : IRequestHandler<UpdateRoomCommand, int>
{
    private readonly IApplicationDbContext _context;

    public UpdateRoomCommandHandler(IApplicationDbContext context, IFileService fileService)
    {
        _context = context;
    }

    public async Task<int> Handle(UpdateRoomCommand request, CancellationToken cancellationToken)
    {
        Room? room = await _context.Rooms.FirstOrDefaultAsync(room => room.Id == request.Id);
        if (room == null) throw new RoomNotFoundException();


        room.RoomNumber = request.RoomNumber;
        room.Status = request.Status;
        room.RoomTypeId = request.RoomTypeId;
        room.HotelId = request.HotelId;
        room.UpdatedDate = DateTime.UtcNow;

        _context.Rooms.Update(room);
        int result = await _context.SaveChangesAsync();
        return result;
    }
}

