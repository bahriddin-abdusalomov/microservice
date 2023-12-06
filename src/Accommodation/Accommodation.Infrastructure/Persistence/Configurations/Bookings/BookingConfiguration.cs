namespace Accommodation.Infrastructure.Persistence.Configurations.Bookings;

public class BookingConfiguration : IEntityTypeConfiguration<Booking>
{
    public void Configure(EntityTypeBuilder<Booking> builder)
    {
        builder.HasKey(r => r.Id);

        builder.HasOne(r => r.Guest)
            .WithMany(h => h.Bookings)
            .HasForeignKey(r => r.GuestId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(r => r.Room)
            .WithOne(b => b.Booking)
            .HasForeignKey<Booking>(b => b.RoomId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
