using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
    
    private static Character dummy = new Character();

    [HttpGet]
    public ActionResult<Character> Get() {
        return Ok(dummy);
    }

}