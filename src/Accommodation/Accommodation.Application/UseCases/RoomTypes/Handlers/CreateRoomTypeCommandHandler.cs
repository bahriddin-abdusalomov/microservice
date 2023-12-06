namespace Accommodation.Application.UseCases.RoomTypes.Hendlers;

public class CreateRoomTypeCommandHandler : IRequestHandler<CreateRoomTypeCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateRoomTypeCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateRoomTypeCommand request, CancellationToken cancellationToken)
    {
        RoomType RoomType = new RoomType()
        {
            Name = request.Name,
            Price = request.Price,
            RoomId = request.RoomId,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            Description = request.Description,
        };

        await  _context.RoomTypes.AddAsync(RoomType);
        int result =  await _context.SaveChangesAsync();

        return result;
    }
}
