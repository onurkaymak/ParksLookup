using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ParksLookupAPI.Models
{
  public class ParksLookupAPIContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Park> Parks { get; set; }

    public DbSet<State> States { get; set; }

    public ParksLookupAPIContext(DbContextOptions<ParksLookupAPIContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<State>()
        .HasData(
          new State { StateId = 1, Name = "Colorado" }
        );

      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Rocky Mountain National Park", StateId = 1, UserId = "onr" }
        );

      var hasher = new PasswordHasher<IdentityUser>();

      builder.Entity<ApplicationUser>()
        .HasData(
          new ApplicationUser { Id = "onr", UserName = "Onur", PasswordHash = hasher.HashPassword(null, "@Test123"), Email = "onur@test.com", NormalizedEmail = "ONUR@TEST.COM" }
        );
      base.OnModelCreating(builder);
    }
  }
}