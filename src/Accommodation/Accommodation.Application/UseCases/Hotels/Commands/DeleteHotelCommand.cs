namespace Accommodation.Application.UseCases.Hotels.Commands;

public class DeleteHotelCommand : IRequest<int>
{
    public long Id { get; set; }
}
