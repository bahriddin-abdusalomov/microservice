using Hospital.Application.Abstractions;
using Hospital.Application.Services.Files;
using Hospital.Application.UseCases.Doctors.Commands;
using Hospital.Domain.Entities.Doctors;

using MediatR;

namespace Hospital.Application.UseCases.Doctors.Handlers;

public class CreateDoctorCommandHandler : IRequestHandler<CreateDoctorCommand, int>
{
    public Task<int> Handle(CreateDoctorCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
