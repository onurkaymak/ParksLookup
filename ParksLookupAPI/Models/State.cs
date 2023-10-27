using System.ComponentModel.DataAnnotations;

namespace ParksLookupAPI.Models
{
  public class State
  {
    public int StateId { get; set; }

    [Required]
    public string Name { get; set; }

    public List<Park> Parks { get; set; } // One to Many
  }
}