namespace Accommodation.Application.UseCases.Staffs.Handlers;

public class CreateStaffCommandHandler : IRequestHandler<CreateStaffCommand, int>
{
    private readonly IApplicationDbContext _context;
    private readonly IFileService _fileService;

    public CreateStaffCommandHandler(IApplicationDbContext context, IFileService fileService)
    {
        _context = context;
        _fileService = fileService;
    }

    public async Task<int> Handle(CreateStaffCommand request, CancellationToken cancellationToken)
    {
        var imagePath = await _fileService.UploadAvatarAsync(request.ImagePath);

        Staff Staff = new Staff()
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Position = request.Position,
            Phone = request.Phone,
            Email = request.Email,
            ImagePath = imagePath,
            Salary = request.Salary,
            HotelId = request.HotelId,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
            DateOfBirth = request.DateOfBirth,

        };

        await _context.Staffs.AddAsync(Staff);
        int result = await _context.SaveChangesAsync(cancellationToken);

        return result;
    }
}
