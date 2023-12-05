namespace Accommodation.Application.UseCases.Hotels.Queries;

public class GetByIdHotelQuery : IRequest<Hotel>
{
    public long Id { get; set; }
}
