namespace Accommodation.Application.UseCases.Staffs.Handlers;

public class DeleteStaffCommandHandler : IRequestHandler<DeleteStaffCommand, int>
{
    private readonly IApplicationDbContext _context;
    private readonly IFileService _fileService;

    public DeleteStaffCommandHandler(IApplicationDbContext context, IFileService fileService)
    {
        _context = context;
        _fileService = fileService;
    }

    public async Task<int> Handle(DeleteStaffCommand request, CancellationToken cancellationToken)
    {
        Staff staff = await _context.Staffs.FirstAsync(staff => staff.Id == request.Id);
        if (staff == null) throw new StaffNotFoundException();

        bool image = await _fileService.DeleteAvatarAsync(staff.ImagePath);
        if (image == false) throw new ImageNotFoundException();

        _context.Staffs.Remove(staff);
        int resutlt = await _context.SaveChangesAsync(cancellationToken);

        return resutlt;
    }                                                 
}
