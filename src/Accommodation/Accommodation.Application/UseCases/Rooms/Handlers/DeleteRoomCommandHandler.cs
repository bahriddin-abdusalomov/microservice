namespace Accommodation.Application.UseCases.Rooms.Handlers;

public class DeleteRoomCommandHandler : IRequestHandler<DeleteRoomCommand, int>
{
    private readonly IApplicationDbContext _context;

    public DeleteRoomCommandHandler(IApplicationDbContext context, IFileService fileService)
    {
        _context = context;
    }

    public async Task<int> Handle(DeleteRoomCommand request, CancellationToken cancellationToken)
    {
        Room room = await _context.Rooms.FirstAsync(room => room.Id == request.Id);
        if (room == null) throw new RoomNotFoundException();

        _context.Rooms.Remove(room);
        int resutlt = await _context.SaveChangesAsync(cancellationToken);

        return resutlt;
    }
}
