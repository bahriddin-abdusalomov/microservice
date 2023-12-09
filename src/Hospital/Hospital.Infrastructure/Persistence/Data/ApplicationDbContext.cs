using Hospital.Application.Abstractions;
using Hospital.Domain.Entities.Appointments;
using Hospital.Domain.Entities.Billings;
using Hospital.Domain.Entities.Doctors;
using Hospital.Domain.Entities.Equipments;
using Hospital.Domain.Entities.Patients;
using Hospital.Domain.Entities.Users;
using Hospital.Infrastructure.Persistence.Configurations.Appointments;
using Hospital.Infrastructure.Persistence.Configurations.Billings;
using Hospital.Infrastructure.Persistence.Configurations.Doctors;
using Hospital.Infrastructure.Persistence.Configurations.Equipments;
using Hospital.Infrastructure.Persistence.Configurations.Patients;

using Microsoft.EntityFrameworkCore;

namespace Hospital.Infrastructure.Persistence.Data;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
    {
        Database.Migrate();
    }

    public DbSet<UserAuthorization> UserAuthorizations { get; set; }
    public DbSet<Administrator> Administrators { get; set; }
    public DbSet<PatientInformation> PatientInformations { get; set; }
    public DbSet<DoctorInformation> DoctorInformations { get; set; }
    public DbSet<AppointmentSchedule> AppointmentSchedules { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<BillingInformation> BillingInformations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserAuthorizationConfiguration());
        modelBuilder.ApplyConfiguration(new AdministratorConfiguration());
        modelBuilder.ApplyConfiguration(new PatientInformationConfiguration());
        modelBuilder.ApplyConfiguration(new DoctorInformationConfiguration());
        modelBuilder.ApplyConfiguration(new AppointmentScheduleConfiguration());
        modelBuilder.ApplyConfiguration(new InventoryConfiguration());
        modelBuilder.ApplyConfiguration(new BillingInformationConfiguration());
    }

}
