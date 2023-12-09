using MediatR;

namespace Hospital.Application.UseCases.Doctors.Commands;

public class DeleteDoctorCommand : IRequest<int>
{
    public int Id { get; set; }
}

