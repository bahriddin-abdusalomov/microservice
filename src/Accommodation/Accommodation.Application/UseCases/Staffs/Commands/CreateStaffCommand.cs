namespace Accommodation.Application.UseCases.Staffs.Commands;

public class CreateStaffCommand : IRequest<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Position Position { get; set; }
    public decimal Salary { get; set; }
    public DateTime DateOfBirth { get; set; }
    [Phone]
    public string Phone { get; set; }
    [Email]
    public string Email { get; set; }
    public DateTime HireDate { get; set; }
    public IFormFile ImagePath { get; set; }
    public long HotelId { get; set; }
}
