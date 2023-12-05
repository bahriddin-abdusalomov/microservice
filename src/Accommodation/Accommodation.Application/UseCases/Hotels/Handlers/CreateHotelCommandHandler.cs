namespace Accommodation.Application.UseCases.Hotels.Handlers;

public class CreateHotelCommandHandler : IRequestHandler<CreateHotelCommand, int>
{
    private readonly IApplicationDbContext _context;
    private readonly IFileService _fileService;

    public CreateHotelCommandHandler(IApplicationDbContext context, IFileService fileService)
    {
        _context = context;
        _fileService = fileService;
    }

    public async Task<int> Handle(CreateHotelCommand request, CancellationToken cancellationToken)
    {
        var imagePath = await _fileService.UploadImageAsync(request.ImagePath);

        Hotel hotel = new Hotel()
        {
            Name = request.Name,
            Address = request.Address,
            Phone = request.Phone,
            Email = request.Email,
            Stars = request.Stars,
            StaffId = request.StaffId,
            RoomId = request.RoomId,
            ImagePath = imagePath,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
        };

        await _context.Hotels.AddAsync(hotel);
        int result = await _context.SaveChangesAsync(cancellationToken);

        return result;
    }
}
