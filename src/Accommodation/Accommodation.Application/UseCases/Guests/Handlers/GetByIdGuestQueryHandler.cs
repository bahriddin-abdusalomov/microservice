namespace Accommodation.Application.UseCases.Guests.Handlers;

public class GetByIdGuestQueryHandler : IRequestHandler<GetByIdGuestQuery, Guest>
{
    private readonly IApplicationDbContext _context;

    public GetByIdGuestQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Guest> Handle(GetByIdGuestQuery request, CancellationToken cancellationToken)
    {
        var guest = await _context.Guests.FindAsync(request.Id);
        if (guest == null) throw new GuestNotFoundException();

        return guest;
    }
}
