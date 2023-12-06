namespace Accommodation.Application.UseCases.Guests.Handlers;

public class CreateGuestCommandHandler : IRequestHandler<CreateGuestCommand, int>
{
    private readonly IApplicationDbContext _context;
    private readonly IFileService _fileService;

    public CreateGuestCommandHandler(IApplicationDbContext context, IFileService fileService)
    {
        _context = context;
        _fileService = fileService;
    }

    public async Task<int> Handle(CreateGuestCommand request, CancellationToken cancellationToken)
    {
        var imagePath = await _fileService.UploadAvatarAsync(request.ImagePath);

        Guest guest = new Guest()
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Address = request.Address,
            Phone = request.Phone,
            Email = request.Email,
            ImagePath = imagePath,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            BookingId = request.BookingId,
            DateOfBirth = request.DateOfBirth,
        };

        await _context.Guests.AddAsync(guest);
        int result = await _context.SaveChangesAsync(cancellationToken);

        return result;
    }
}
