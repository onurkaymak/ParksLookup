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
  }
}