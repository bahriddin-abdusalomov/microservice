namespace Accommodation.Application.Abstractions;

public interface IApplicationDbContext
{
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<RoomType> RoomTypes { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Staff> Staffs { get; set; }

    public Task<int> SaveChangesAsync(CancellationToken collactionToken = default);
}
