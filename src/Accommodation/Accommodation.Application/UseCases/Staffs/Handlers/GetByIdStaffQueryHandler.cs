namespace Accommodation.Application.UseCases.Staffs.Handlers;

public class GetByIdStaffQueryHandler : IRequestHandler<GetByIdStaffQuery, Staff>
{
    private readonly IApplicationDbContext _context;

    public GetByIdStaffQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Staff> Handle(GetByIdStaffQuery request, CancellationToken cancellationToken)
    {
        var staff = await _context.Staffs.FindAsync(request.Id);
        if (staff == null) throw new StaffNotFoundException();

        return staff;
    }
}
