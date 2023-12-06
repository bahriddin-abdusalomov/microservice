namespace Accommodation.Application.UseCases.Guests.Handlers;

public class GetAllGuestQueryHandler : IRequestHandler<GetAllGuestQuery, List<Guest>>
{
    private readonly IApplicationDbContext _context;

    public GetAllGuestQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Guest>> Handle(GetAllGuestQuery request, CancellationToken cancellationToken)
    {
        var guests = await _context.Guests.ToListAsync();
        return guests;
    }
}

