using MediatR;

namespace Hospital.Application.UseCases.Doctors.Commands;

public class CreateDoctorCommand : IRequest<int>
{
    public string Name { get; set; }
    public string Specialty { get; set; }
    public string ContactNumber { get; set; }
    public string Email { get; set; }
    public string Image { get; set; }
}
