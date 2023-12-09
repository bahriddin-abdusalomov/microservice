using Hospital.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class AdministratorConfiguration : IEntityTypeConfiguration<Administrator>
{
    public void Configure(EntityTypeBuilder<Administrator> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.FullName).IsRequired().HasMaxLength(255);
        builder.Property(a => a.ContactNumber).HasMaxLength(15);
        builder.Property(a => a.Email).HasMaxLength(255);

        builder.HasOne(a => a.UserAuthorization)
            .WithOne()
            .HasForeignKey<Administrator>(a => a.UserID)
            .IsRequired();
    }
}
