namespace Accommodation.Application.UseCases.Guests.Commands;

public class DeleteGuestCommand : IRequest<int>
{
    public long Id { get; set; }
}
