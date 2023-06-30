using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = "434f5db4-aba3-4c4c-30ba-95a40fb57a63",
                        UserId = "0182ece0-bb23-4dbe-900e-8d6f0b005729"
                    }, 
                    new IdentityUserRole<string>
                    {
                        RoleId = "2adf4db5-aba3-4c4c-30ba-22a40db57b54",
                        UserId = "102f5db4-aba3-4c4c-80ca-95a40fb57a62"
                    }
                );
        }
    }
}