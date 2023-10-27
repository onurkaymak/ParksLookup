using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksLookupAPI.Models;


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


  [HttpPost]
  public async Task<ActionResult<Park>> Post(Park park)
  {
    _db.Parks.Add(park);
    await _db.SaveChangesAsync();
    return NoContent();
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


}









