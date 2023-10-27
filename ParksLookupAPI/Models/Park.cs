using System.ComponentModel.DataAnnotations;


namespace ParksLookupAPI.Models
{
  public class Park
  {
    public int ParkId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public DateTime EstablishedAsPark { get; set; }

    [Required]
    public int StateId { get; set; }

    [Required]
    public string UserId { get; set; }

    public State State { get; set; } // navigation property - One to Many

    public ApplicationUser User { get; set; } // navigation property - One to Many

  }
}

