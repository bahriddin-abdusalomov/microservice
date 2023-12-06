namespace Accommodation.Application.UseCases.Guests.Commands;

public class CreateGuestCommand : IRequest<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    [Phone]
    public string Phone { get; set; }
    [Email]
    public string Email { get; set; }
    public IFormFile ImagePath { get; set; }
    public long BookingId { get; set; }
}
