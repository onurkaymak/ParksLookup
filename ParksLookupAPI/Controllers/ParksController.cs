using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksLookupAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;



namespace ParksLookupAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ParksController : ControllerBase
{
  private readonly ParksLookupAPIContext _db;

  public ParksController(ParksLookupAPIContext db)
  {
    _db = db;
  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<Park>>> Get(int stateId, string dateFrom, string dateTo)
  {
    IQueryable<Park> query = _db.Parks.AsQueryable();

    try
    {
      if (stateId > 0)
      {
        query = query.Where(entry => entry.StateId == stateId);
      }

      if (dateFrom != null)
      {
        query = query.Where(entry => entry.EstablishedAsPark >= DateTime.Parse(dateFrom));
      }

      if (dateTo != null)
      {
        query = query.Where(entry => entry.EstablishedAsPark <= DateTime.Parse(dateTo));
      }

      return await query
                        .Include(park => park.State)
            .ToListAsync();
    }
    catch
    {
      return BadRequest();
    }
  }

  [Authorize]
  [HttpPost]
  public async Task<ActionResult<Park>> Post(Park park)
  {
    _db.Parks.Add(park);
    await _db.SaveChangesAsync();
    return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
  }


  [HttpGet("{id}")]
  public async Task<ActionResult<Park>> GetPark(int id)
  {
    Park park = await _db.Parks
                              .Include(park => park.State)
                              .Include(park => park.User)
                              .FirstOrDefaultAsync(park => park.ParkId == id);

    if (park == null)
    {
      return NotFound();
    }

    return park;
  }

  [Authorize]
  [HttpPut("{id}")]
  public async Task<IActionResult> Put(int id, Park park, string userId)
  {
    if (id != park.ParkId || userId != park.UserId || !IsAuthor(id, userId))
    {
      return BadRequest();
    }

    try
    {
      _db.Parks.Update(park);

      await _db.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
      if (!ParkExists(id))
      {
        return NotFound();
      }
      else
      {
        throw;
      }
    }
    return NoContent();
  }

  private bool ParkExists(int id)
  {
    return _db.Parks.Any(e => e.ParkId == id);
  }

  private bool IsAuthor(int id, string userId)
  {
    return _db.Parks.Any(e => e.ParkId == id && e.User.Id == userId);
  }

  [Authorize]
  [HttpDelete("{id}")]
  public async Task<IActionResult> DeletePark(int id)
  {
    Park park = await _db.Parks.FindAsync(id);
    if (park == null)
    {
      return NotFound();
    }

    _db.Parks.Remove(park);
    await _db.SaveChangesAsync();

    return NoContent();
  }
}









