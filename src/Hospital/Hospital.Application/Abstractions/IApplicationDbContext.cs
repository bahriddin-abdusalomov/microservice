using Hospital.Domain.Entities.Appointments;
using Hospital.Domain.Entities.Billings;
using Hospital.Domain.Entities.Doctors;
using Hospital.Domain.Entities.Equipments;
using Hospital.Domain.Entities.Patients;
using Hospital.Domain.Entities.Users;

using Microsoft.EntityFrameworkCore;

namespace Hospital.Application.Abstractions;

public interface IApplicationDbContext
{
    public DbSet<UserAuthorization> UserAuthorizations { get; set; }
    public DbSet<Administrator> Administrators { get; set; }
    public DbSet<PatientInformation> PatientInformations { get; set; }
    public DbSet<DoctorInformation> DoctorInformations { get; set; }
    public DbSet<AppointmentSchedule> AppointmentSchedules { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<BillingInformation> BillingInformations { get; set; }

    public Task<int> SaveChangesAsync(CancellationToken collactionToken = default);
}
