using ASPNETCoreIdentityDemo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ASPNETCoreIdentityDemo.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Rename Tables
            builder.Entity<ApplicationUser>().ToTable("Users");
            builder.Entity<ApplicationRole>().ToTable("Roles");
            builder.Entity<IdentityUserRole<Guid>>().ToTable("UserRoles");
            builder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaims");
            builder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogins");
            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserToken<Guid>>().ToTable("UserTokens");

            // Seed initial roles using HasData
            var adminRoleId = Guid.Parse("c8d89a25-4b96-4f20-9d79-7f8a54c5213d");
            var userRoleId = Guid.Parse("b92f0a3e-573b-4b12-8db1-2ccf6d58a34a");
            var managerRoleId = Guid.Parse("d7f4a42e-1c1b-4c9f-8a50-55f6b234e8e2");
            var guestRoleId = Guid.Parse("f2e6b8a1-9d43-4a7c-9f32-71d7c5dbe9f0");

            builder.Entity<ApplicationRole>().HasData(
                new ApplicationRole
                {
                    Id = adminRoleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    Description = "Administrator role with full access permissions",
                    IsActive = true,
                    ConcurrencyStamp = "11111111-1111-1111-1111-111111111111",
                    CreatedOn = new DateTime(2025, 10, 17, 10, 35, 00, DateTimeKind.Utc),
                    ModifiedOn = new DateTime(2025, 10, 17, 10, 35, 00, DateTimeKind.Utc)
                },
                new ApplicationRole
                {
                    Id = userRoleId,
                    Name = "User",
                    NormalizedName = "USER",
                    Description = "Standard user role with limited access",
                    IsActive = true,
                    ConcurrencyStamp = "22222222-2222-2222-2222-222222222222",
                    CreatedOn = new DateTime(2025, 10, 17, 10, 35, 00, DateTimeKind.Utc),
                    ModifiedOn = new DateTime(2025, 10, 17, 10, 35, 00, DateTimeKind.Utc)
                },
                new ApplicationRole
                {
                    Id = managerRoleId,
                    Name = "Manager",
                    NormalizedName = "MANAGER",
                    Description = "Manager role with extended management privileges",
                    IsActive = true,
                    ConcurrencyStamp = "33333333-3333-3333-3333-333333333333",
                    CreatedOn = new DateTime(2025, 10, 17, 10, 35, 00, DateTimeKind.Utc),
                    ModifiedOn = new DateTime(2025, 10, 17, 10, 35, 00, DateTimeKind.Utc)
                },
                new ApplicationRole
                {
                    Id = guestRoleId,
                    Name = "Guest",
                    NormalizedName = "GUEST",
                    Description = "Guest role with read-only access",
                    IsActive = true,
                    ConcurrencyStamp = "44444444-4444-4444-4444-444444444444",
                    CreatedOn = new DateTime(2025, 10, 17, 10, 35, 00, DateTimeKind.Utc),
                    ModifiedOn = new DateTime(2025, 10, 17, 10, 35, 00, DateTimeKind.Utc)
                }
            );
        }

        public DbSet<Address> Addresses { get; set; }
    }
}
