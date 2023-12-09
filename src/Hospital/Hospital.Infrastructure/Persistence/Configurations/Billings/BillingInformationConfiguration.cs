using Hospital.Domain.Entities.Billings;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital.Infrastructure.Persistence.Configurations.Billings;

public class BillingInformationConfiguration : IEntityTypeConfiguration<BillingInformation>
{
    public void Configure(EntityTypeBuilder<BillingInformation> builder)
    {
        builder.HasKey(b => b.Id);
        builder.Property(b => b.PaymentStatus).IsRequired().HasMaxLength(50);

        builder.HasOne(b => b.PatientInformation)
            .WithMany()
            .HasForeignKey(b => b.PatientID)
            .IsRequired();
    }
}
