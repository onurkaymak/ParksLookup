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
          new State { StateId = 1, Name = "AL" },
          new State { StateId = 2, Name = "AK" },
          new State { StateId = 3, Name = "AS" },
          new State { StateId = 4, Name = "AZ" },
          new State { StateId = 5, Name = "AR" },
          new State { StateId = 6, Name = "CA" },
          new State { StateId = 7, Name = "CO" },
          new State { StateId = 8, Name = "CT" },
          new State { StateId = 9, Name = "DE" },
          new State { StateId = 10, Name = "DC" },
          new State { StateId = 11, Name = "FL" },
          new State { StateId = 12, Name = "GA" },
          new State { StateId = 13, Name = "GU" },
          new State { StateId = 14, Name = "HI" },
          new State { StateId = 15, Name = "ID" },
          new State { StateId = 16, Name = "IL" },
          new State { StateId = 17, Name = "IN" },
          new State { StateId = 18, Name = "IA" },
          new State { StateId = 19, Name = "KS" },
          new State { StateId = 20, Name = "KY" },
          new State { StateId = 21, Name = "LA" },
          new State { StateId = 22, Name = "ME" },
          new State { StateId = 23, Name = "MD" },
          new State { StateId = 24, Name = "MA" },
          new State { StateId = 25, Name = "MI" },
          new State { StateId = 26, Name = "MN" },
          new State { StateId = 27, Name = "MS" },
          new State { StateId = 28, Name = "MO" },
          new State { StateId = 29, Name = "MT" },
          new State { StateId = 30, Name = "NE" },
          new State { StateId = 31, Name = "NV" },
          new State { StateId = 32, Name = "NH" },
          new State { StateId = 33, Name = "NJ" },
          new State { StateId = 34, Name = "NM" },
          new State { StateId = 35, Name = "NY" },
          new State { StateId = 36, Name = "NC" },
          new State { StateId = 37, Name = "ND" },
          new State { StateId = 38, Name = "MP" },
          new State { StateId = 39, Name = "OH" },
          new State { StateId = 40, Name = "OK" },
          new State { StateId = 41, Name = "OR" },
          new State { StateId = 42, Name = "PA" },
          new State { StateId = 43, Name = "PR" },
          new State { StateId = 44, Name = "RI" },
          new State { StateId = 45, Name = "SC" },
          new State { StateId = 46, Name = "SD" },
          new State { StateId = 47, Name = "TN" },
          new State { StateId = 48, Name = "TX" },
          new State { StateId = 49, Name = "UT" },
          new State { StateId = 50, Name = "VT" },
          new State { StateId = 51, Name = "VA" },
          new State { StateId = 52, Name = "VI" },
          new State { StateId = 53, Name = "WA" },
          new State { StateId = 54, Name = "WV" },
          new State { StateId = 55, Name = "WI" },
          new State { StateId = 56, Name = "WY" }
        );

      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Rocky Mountain National Park", EstablishedAsPark = new DateTime(1915, 1, 26), StateId = 7, UserId = "onr" },
           new Park { ParkId = 2, Name = "North Cascades National Park", EstablishedAsPark = new DateTime(1968, 10, 2), StateId = 53, UserId = "onr" },
           new Park { ParkId = 3, Name = "Mount Rainier National Park", EstablishedAsPark = new DateTime(1899, 3, 2), StateId = 53, UserId = "onr" },
           new Park { ParkId = 4, Name = "Crater Lake National Park", EstablishedAsPark = new DateTime(1902, 5, 22), StateId = 41, UserId = "onr" }
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