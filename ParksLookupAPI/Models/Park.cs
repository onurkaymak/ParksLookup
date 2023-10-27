using System.ComponentModel.DataAnnotations;

namespace ParksLookupAPI.Models
{
  public class Park
  {
    public int ParkId { get; set; }

    [Required]
    public string Name { get; set; }

    public int StateId { get; set; }

    public string UserId { get; set; }

    [Required]
    public State State { get; set; } // navigation property - One to Many

    public ApplicationUser User { get; set; } // navigation property - One to Many

  }
}

