using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "0182ece0-bb23-4dbe-900e-8d6f0b005729",
                    Email = "admin@test.com",
                    NormalizedEmail = "ADMIN@TEST.COM",
                    UserName = "admin@test.com",
                    NormalizedUserName = "ADMIN@TEST.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Hola123!"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "102f5db4-aba3-4c4c-80ca-95a40fb57a62",
                    Email = "jcelis@itx.com",
                    NormalizedEmail = "JCELIS@ITX.COM",
                    UserName = "jcelis@itx.com",
                    NormalizedUserName = "JCELIS@ITX.COM",
                    FirstName = "Julio",
                    LastName = "Celis",
                    PasswordHash = hasher.HashPassword(null, "Hola123!"),
                    EmailConfirmed = true
                }
            );
        }
    }
}