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

}









