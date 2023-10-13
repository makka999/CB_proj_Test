using CB_proj_Test.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CB_proj_Test.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserModel> UserModels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            string ADMINROLE_ID = "b2461abb-d772-adb3-caba-89a58cb66c30";
            string USERROLE_ID = "757f2ssc-5321-5454-b865-baabba9f48b1";
            string ADMIN_ID = "e6e2f41d-9c07-488e-9d0f-ecfa25c4545c";
            string USER_ID = "4c0331ea-76af-4c3c-b985-911653053c0a";

            base.OnModelCreating(builder);

            IdentityRole adminRole = new IdentityRole() { Id = ADMINROLE_ID, Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "ADMIN" };
            IdentityRole userRole = new IdentityRole() { Id = USERROLE_ID, Name = "User", ConcurrencyStamp = "2", NormalizedName = "USER" };
            builder.Entity<IdentityRole>().HasData(adminRole);
            builder.Entity<IdentityRole>().HasData(userRole);

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ADMINROLE_ID,
                UserId = ADMIN_ID
            });
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = USERROLE_ID,
                UserId = USER_ID
            });
        }
    }
}