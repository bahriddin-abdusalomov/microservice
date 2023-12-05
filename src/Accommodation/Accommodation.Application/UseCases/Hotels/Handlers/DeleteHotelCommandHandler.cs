namespace Accommodation.Application.UseCases.Hotels.Handlers;

public class DeleteHotelCommandHandler : IRequestHandler<DeleteHotelCommand, int>
{
    private readonly IApplicationDbContext _context;
    private readonly IFileService _fileService;

    public DeleteHotelCommandHandler(IApplicationDbContext context, IFileService fileService)
    {
        _context = context;
        _fileService = fileService;
    }

    public async Task<int> Handle(DeleteHotelCommand request, CancellationToken cancellationToken)
    {
        Hotel hotel = await _context.Hotels.FirstAsync(hotel => hotel.Id == request.Id);
        if (hotel == null) throw new HotelNotFoundException();

        bool image = await _fileService.DeleteImageAsync(hotel.ImagePath);
        if (image == false) throw new ImageNotFoundException();

        _context.Hotels.Remove(hotel);
        int resutlt = await _context.SaveChangesAsync(cancellationToken);

        return resutlt;
    }                                                 
}
