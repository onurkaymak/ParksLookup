using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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


    // [JsonIgnore]
    public State State { get; set; } // navigation property - One to Many

    // [JsonIgnore]
    public ApplicationUser User { get; set; } // navigation property - One to Many

  }
}

