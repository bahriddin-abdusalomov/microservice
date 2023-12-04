using Accommodation.Domain.Entities.Hotels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Accommodation.Infrastructure.Persistence.Configurations.Hotels;

public class HotelConfigoration : IEntityTypeConfiguration<Hotel>
{
    public void Configure(EntityTypeBuilder<Hotel> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .HasDefaultValue("name")
            .HasMaxLength(30)
            .IsRequired();

        builder.Property(x => x.Phone)
            .HasDefaultValue("+998944396669")
            .HasMaxLength(13)
            .IsRequired();

        builder.Property(x => x.Name)
            .HasDefaultValue("example@gmail.com")
            .HasMaxLength(30)
            .IsRequired();

        builder.HasMany(h => h.Staffs)
                  .WithOne(s => s.Hotel)
                  .HasForeignKey(s => s.HotelId)
                  .OnDelete(DeleteBehavior.Cascade); ;

        builder.HasMany(h => h.Rooms)
               .WithOne(r => r.Hotel)
               .HasForeignKey(r => r.HotelId)
               .OnDelete(DeleteBehavior.Cascade); ;
    }
}
