namespace Accommodation.Application.UseCases.Staffs.Handlers;

public class GetAllStaffQueryHandler : IRequestHandler<GetAllStaffQuery, List<Staff>>
{
    private readonly IApplicationDbContext _context;

    public GetAllStaffQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Staff>> Handle(GetAllStaffQuery request, CancellationToken cancellationToken)
    {
        var staffs = await _context.Staffs.ToListAsync();
        return staffs;
    }
}

