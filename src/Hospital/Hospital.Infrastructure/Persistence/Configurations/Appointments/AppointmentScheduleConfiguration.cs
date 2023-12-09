using Hospital.Domain.Entities.Appointments;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital.Infrastructure.Persistence.Configurations.Appointments;
public class AppointmentScheduleConfiguration : IEntityTypeConfiguration<AppointmentSchedule>
{
    public void Configure(EntityTypeBuilder<AppointmentSchedule> builder)
    {
        builder.HasKey(a => a.Id);
        // Add other configurations as needed
    }
}

