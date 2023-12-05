namespace Accommodation.Application.UseCases.Hotels.Handlers;

public class GetByIdHotelQueryHandler : IRequestHandler<GetByIdHotelQuery, Hotel>
{
    private readonly IApplicationDbContext _context;

    public GetByIdHotelQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Hotel> Handle(GetByIdHotelQuery request, CancellationToken cancellationToken)
    {
        var hotel = await _context.Hotels.FindAsync(request.Id);
        if (hotel == null) throw new HotelNotFoundException();

        return hotel;
    }
}
