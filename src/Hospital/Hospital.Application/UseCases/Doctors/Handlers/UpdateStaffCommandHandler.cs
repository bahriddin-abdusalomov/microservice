namespace Accommodation.Application.UseCases.Staffs.Handlers;

public class UpdateStaffCommandHandler : IRequestHandler<UpdateStaffCommand, int>
{
    private readonly IApplicationDbContext _context;
    private readonly IFileService _fileService;

    public UpdateStaffCommandHandler(IApplicationDbContext context, IFileService fileService)
    {
        _context = context;
        _fileService = fileService;
    }

    public async Task<int> Handle(UpdateStaffCommand request, CancellationToken cancellationToken)
    {
        Staff? staff = await _context.Staffs.FirstOrDefaultAsync(Staff => Staff.Id == request.Id);
        if (staff == null) throw new StaffNotFoundException();

        if(staff.ImagePath is not null)
        {
            var image = await _fileService.DeleteAvatarAsync(staff.ImagePath);
            if (image == false) throw new ImageNotFoundException();

            string newImagePath = await _fileService.UploadAvatarAsync(request.ImagePath);
            staff.ImagePath = newImagePath;
        }

        staff.FirstName = request.FirstName;
        staff.LastName = request.LastName;
        staff.Position = request.Position;
        staff.Salary = request.Salary;
        staff.Email = request.Email;
        staff.Phone = request.Phone;
        staff.DateOfBirth = request.DateOfBirth;
        staff.HotelId = request.HotelId;
        staff.UpdatedDate = DateTime.UtcNow;

        _context.Staffs.Update(staff);
        int result =  await _context.SaveChangesAsync();
        return result; 
    }
}
