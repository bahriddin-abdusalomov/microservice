using Accommodation.Application.Abstractions;
using Accommodation.Domain.Entities.Bookings;
using Accommodation.Domain.Entities.Guests;
using Accommodation.Domain.Entities.Hotels;
using Accommodation.Domain.Entities.Rooms;
using Accommodation.Domain.Entities.Staffs;
using Accommodation.Infrastructure.Persistence.Configurations.Bookings;
using Accommodation.Infrastructure.Persistence.Configurations.Guests;
using Accommodation.Infrastructure.Persistence.Configurations.Hotels;
using Accommodation.Infrastructure.Persistence.Configurations.Rooms;
using Accommodation.Infrastructure.Persistence.Configurations.Staffs;
using Microsoft.EntityFrameworkCore;

namespace Accommodation.Infrastructure.Persistence.Data;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Staff> Staffs { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<RoomType> RoomTypes { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Guest> Guests { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BookingConfiguration());
        modelBuilder.ApplyConfiguration(new GuestConfiguration());
        modelBuilder.ApplyConfiguration(new HotelConfigoration());
        modelBuilder.ApplyConfiguration(new StaffConfiguration());
        modelBuilder.ApplyConfiguration(new RoomConfiguration());
        modelBuilder.ApplyConfiguration(new RoomConfiguration());
    }
}
 