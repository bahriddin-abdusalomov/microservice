namespace Accommodation.Infrastructure.Persistence.Configurations.Staffs;

public class StaffConfiguration : IEntityTypeConfiguration<Staff>
{
    public void Configure(EntityTypeBuilder<Staff> builder)
    {
        builder.HasKey(s => s.Id);

        builder.Property(s => s.FirstName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(s => s.LastName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(s => s.Salary)
            .HasColumnType("decimal(18,2)")
            .IsRequired();

        builder.Property(s => s.Phone)
            .HasDefaultValue("+998944396669")
            .IsRequired()
            .HasMaxLength(13);

        builder.Property(s => s.Email)
            .HasDefaultValue("example@gmail.com")
            .IsRequired()
            .HasMaxLength(100);

        builder.HasOne(s => s.Hotel)
            .WithMany(h => h.Staffs)
            .HasForeignKey(s => s.HotelId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.ToTable("Staffs");
    }
}
