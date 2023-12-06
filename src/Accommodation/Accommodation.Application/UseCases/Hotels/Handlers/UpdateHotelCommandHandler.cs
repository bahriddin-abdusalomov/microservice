namespace Accommodation.Application.UseCases.Hotels.Handlers;

public class UpdateHotelCommandHandler : IRequestHandler<UpdateHotelCommand, int>
{
    private readonly IApplicationDbContext _context;
    private readonly IFileService _fileService;

    public UpdateHotelCommandHandler(IApplicationDbContext context, IFileService fileService)
    {
        _context = context;
        _fileService = fileService;
    }

    public async Task<int> Handle(UpdateHotelCommand request, CancellationToken cancellationToken)
    {
        Hotel? hotel = await _context.Hotels.FirstOrDefaultAsync(hotel => hotel.Id == request.HotelId);
        if (hotel == null) throw new HotelNotFoundException();

        if(hotel.ImagePath is not null)
        {
            var image = await _fileService.DeleteImageAsync(hotel.ImagePath);
            if (image == false) throw new ImageNotFoundException();

            string newImagePath = await _fileService.UploadImageAsync(request.ImagePath);
            hotel.ImagePath = newImagePath;
        }

        hotel.Name = request.Name;
        hotel.Address = request.Address;
        hotel.Email = request.Email;
        hotel.Phone = request.Phone;
        hotel.Stars = request.Stars;
        hotel.StaffId = request.StaffId;
        hotel.RoomId = request.RoomId;
        hotel.UpdatedDate = DateTime.UtcNow;

        _context.Hotels.Update(hotel);
        int result =  await _context.SaveChangesAsync();
        return result; 
    }
}
