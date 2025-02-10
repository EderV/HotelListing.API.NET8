using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "e40b55f8-0b34-4ebf-b5f7-cf93dd4f1d6a",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new IdentityRole
                {
                    Id = "f78c2bb9-5dfc-4cb3-9b8f-95cb0a2a491a",
                    Name = "User",
                    NormalizedName = "USER"
                }
            );
        }
    }
}
