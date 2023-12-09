using Hospital.Domain.Entities.Patients;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital.Infrastructure.Persistence.Configurations.Patients;
public class PatientInformationConfiguration : IEntityTypeConfiguration<PatientInformation>
{
    public void Configure(EntityTypeBuilder<PatientInformation> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name).IsRequired().HasMaxLength(255);
        // Add other configurations as needed
    }
}

