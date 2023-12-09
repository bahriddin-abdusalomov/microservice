using Hospital.Application.Abstractions;
using Hospital.Application.Services.Files;
using Hospital.Application.UseCases.Doctors.Commands;
using Hospital.Domain.Entities.Doctors;

using MediatR;

using Microsoft.EntityFrameworkCore;

namespace Hospital.Application.UseCases.Doctors.Handlers;

public class DeleteDoctorCommandHandler : IRequestHandler<DeleteDoctorCommand, int>
{
    private readonly IApplicationDbContext _context;
    private readonly IFileService _fileService;

    public DeleteDoctorCommandHandler(IApplicationDbContext context, IFileService fileService)
    {
        _context = context;
        _fileService = fileService;
    }

    public async Task<int> Handle(DeleteDoctorCommand request, CancellationToken cancellationToken)
    {
        DoctorInformation doctor = await _context.DoctorInformations.FirstAsync(Doctor => Doctor.Id == request.Id);
        if (doctor == null) throw new DirectoryNotFoundException();

        bool image = await _fileService.DeleteAvatarAsync(doctor.Image);
        if (image == false) throw new NotImplementedException();

        _context.DoctorInformations.Remove(doctor);
        int resutlt = await _context.SaveChangesAsync(cancellationToken);

        return resutlt;
    }                                                 
}
