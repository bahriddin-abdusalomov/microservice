namespace Accommodation.Application.UseCases.RoomTypes.Handlers;

public class UpdateRoomTypeCommandHandler : IRequestHandler<UpdateRoomTypeCommand, int>
{
    private readonly IApplicationDbContext _context;

    public UpdateRoomTypeCommandHandler(IApplicationDbContext context, IFileService fileService)
    {
        _context = context;
    }

    public async Task<int> Handle(UpdateRoomTypeCommand request, CancellationToken cancellationToken)
    {
        RoomType? roomType = await _context.RoomTypes.FirstOrDefaultAsync(RoomType => RoomType.Id == request.Id);
        if (roomType == null) throw new RoomTypeNotFoundException();


        roomType.Name = request.Name;
        roomType.Price = request.Price;
        roomType.RoomId = request.RoomId;
        roomType.UpdatedDate = DateTime.UtcNow;
        roomType.Description = request.Description;

        _context.RoomTypes.Update(roomType);
        int result = await _context.SaveChangesAsync();
        return result;
    }
}

