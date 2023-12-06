using Accommodation.Application.UseCases.Guests.Commands;
using Accommodation.Domain.Exceptions.Guests;

namespace Accommodation.Application.UseCases.Guests.Handlers;

public class DeleteGuestCommandHandler : IRequestHandler<DeleteGuestCommand, int>
{
    private readonly IApplicationDbContext _context;
    private readonly IFileService _fileService;

    public DeleteGuestCommandHandler(IApplicationDbContext context, IFileService fileService)
    {
        _context = context;
        _fileService = fileService;
    }

    public async Task<int> Handle(DeleteGuestCommand request, CancellationToken cancellationToken)
    {
        Guest guest = await _context.Guests.FirstAsync(guest => guest.Id == request.Id);
        if (guest == null) throw new GuestNotFoundException();

        bool image = await _fileService.DeleteAvatarAsync(guest.ImagePath);
        if (image == false) throw new ImageNotFoundException();

        _context.Guests.Remove(guest);
        int resutlt = await _context.SaveChangesAsync(cancellationToken);

        return resutlt;
    }                                                 
}
