namespace Accommodation.Application.Abstractions;

public interface IApplicationDbContext
{
    public DbSet<Room> Rooms { get; set; }

    public Task<int> SaveChangesAsync(CancellationToken collactionToken = default);
}       
