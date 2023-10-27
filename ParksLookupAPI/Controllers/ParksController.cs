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
                        .Include(park => park.User)
                        .ToListAsync();
    }
    catch
    {
      return BadRequest();
    }
  }


}









