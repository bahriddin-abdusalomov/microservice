namespace Accommodation.Application.UseCases.Guests.Queries;

public class GetByIdGuestQuery : IRequest<Guest>
{
    public long Id { get; set; }
}
