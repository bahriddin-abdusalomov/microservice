namespace Accommodation.Application.UseCases.RoomTypes.Handlers;

public class DeleteRoomTypeCommandHandler : IRequestHandler<DeleteRoomTypeCommand, int>
{
    private readonly IApplicationDbContext _context;

    public DeleteRoomTypeCommandHandler(IApplicationDbContext context, IFileService fileService)
    {
        _context = context;
    }

    public async Task<int> Handle(DeleteRoomTypeCommand request, CancellationToken cancellationToken)
    {
        RoomType RoomType = await _context.RoomTypes.FirstAsync(RoomType => RoomType.Id == request.Id);
        if (RoomType == null) throw new RoomTypeNotFoundException();

        _context.RoomTypes.Remove(RoomType);
        int resutlt = await _context.SaveChangesAsync(cancellationToken);

        return resutlt;
    }
}
