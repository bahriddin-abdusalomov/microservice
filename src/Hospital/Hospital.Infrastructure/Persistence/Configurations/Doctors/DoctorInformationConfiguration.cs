using Hospital.Domain.Entities.Doctors;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital.Infrastructure.Persistence.Configurations.Doctors;
public class DoctorInformationConfiguration : IEntityTypeConfiguration<DoctorInformation>
{
    public void Configure(EntityTypeBuilder<DoctorInformation> builder)
    {
        builder.HasKey(d => d.Id);
        builder.Property(d => d.Name).IsRequired().HasMaxLength(255);
        // Add other configurations as needed
    }
}
