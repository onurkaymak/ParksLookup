using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ParksLookupAPI.Models
{
  public class State
  {
    public int StateId { get; set; }

    [Required]
    public string Name { get; set; }

    [JsonIgnore]
    public List<Park> Parks { get; set; } // One to Many
  }
}