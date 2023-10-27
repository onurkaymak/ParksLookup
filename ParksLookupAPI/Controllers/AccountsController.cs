using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ParksLookupAPI.Models;
using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;

namespace ParksLookupAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountsController : ControllerBase
{

  private readonly UserManager<ApplicationUser> _userManager;
  private readonly SignInManager<ApplicationUser> _signInManager;
  private readonly IConfiguration _configuration;

  public AccountsController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
  {
    _userManager = userManager;
    _signInManager = signInManager;
    _configuration = configuration;
  }

  [HttpPost("register")]
  public async Task<IActionResult> Register([FromBody] RegisterDto user)
  {
    var userExists = await _userManager.FindByEmailAsync(user.Email);

    if (userExists != null)
    {
      return BadRequest(new { status = "error", message = "Email already exists" });
    }

    var newUser = new ApplicationUser() { Email = user.Email, UserName = user.UserName };
    var result = await _userManager.CreateAsync(newUser, user.Password);

    if (result.Succeeded)
    {
      return Ok(new { status = "success", message = "User has been successfully created" });
    }
    else
    {
      return BadRequest(result.Errors);
    }
  }


}