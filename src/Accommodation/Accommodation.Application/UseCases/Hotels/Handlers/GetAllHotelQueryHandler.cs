namespace Accommodation.Application.UseCases.Hotels.Handlers;

public class GetAllHotelQueryHandler : IRequestHandler<GetAllHotelQuery, List<Hotel>>
{
    private readonly IApplicationDbContext _context;

    public GetAllHotelQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Hotel>> Handle(GetAllHotelQuery request, CancellationToken cancellationToken)
    {
        var hotels = await _context.Hotels.ToListAsync();
        return hotels;
    }
}

