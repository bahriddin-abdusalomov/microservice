namespace Accommodation.Application.UseCases.Guests.Handlers;

public class UpdateGuestCommandHandler : IRequestHandler<UpdateGuestCommand, int>
{
    private readonly IApplicationDbContext _context;
    private readonly IFileService _fileService;

    public UpdateGuestCommandHandler(IApplicationDbContext context, IFileService fileService)
    {
        _context = context;
        _fileService = fileService;
    }

    public async Task<int> Handle(UpdateGuestCommand request, CancellationToken cancellationToken)
    {
        Guest? guest = await _context.Guests.FirstOrDefaultAsync(Guest => Guest.Id == request.Id);
        if (guest == null) throw new GuestNotFoundException();

        if(guest.ImagePath is not null)
        {
            var image = await _fileService.DeleteAvatarAsync(guest.ImagePath);
            if (image == false) throw new ImageNotFoundException();

            string newImagePath = await _fileService.UploadAvatarAsync(request.ImagePath);
            guest.ImagePath = newImagePath;
        }

        guest.FirstName = request.FirstName;
        guest.LastName = request.LastName;
        guest.Address = request.Address;
        guest.Email = request.Email;
        guest.Phone = request.Phone;
        guest.DateOfBirth = request.DateOfBirth;
        guest.BookingId = request.BookingId;
        guest.UpdatedDate = DateTime.UtcNow;

        _context.Guests.Update(guest);
        int result =  await _context.SaveChangesAsync();
        return result; 
    }
}
