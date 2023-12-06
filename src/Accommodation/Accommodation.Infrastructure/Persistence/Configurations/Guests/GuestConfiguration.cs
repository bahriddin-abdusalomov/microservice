namespace Accommodation.Infrastructure.Persistence.Configurations.Guests;

public class GuestConfiguration : IEntityTypeConfiguration<Guest>
{
    public void Configure(EntityTypeBuilder<Guest> builder)
    {
        builder.HasKey(r => r.Id);

        builder.Property(s => s.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(s => s.LastName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(s => s.Phone)
            .HasDefaultValue("+998944396669")
            .IsRequired()
            .HasMaxLength(13);

        builder.Property(s => s.Email)
            .HasDefaultValue("example@gmail.com")
            .IsRequired()
            .HasMaxLength(100);
    }
}
