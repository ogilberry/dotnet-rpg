using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
    
    private static List<Character> characters = new List<Character>(){
        new Character(),
        new Character {Id = new Guid(), Name = "Greg"}
    };

    [HttpGet("GetAll")]
    public ActionResult<List<Character>> Get() {
        return Ok(characters);
    }

    [HttpGet("{id}")]
    public ActionResult<Character> GetSingle(Guid id) {
        return Ok(characters.FirstOrDefault(c => c.Id == id));
    }

    [HttpPost]
    public ActionResult<List<Character>> AddCharacter(Character newCharacter){
        characters.Add(newCharacter);
        return Ok(characters);
    }

}