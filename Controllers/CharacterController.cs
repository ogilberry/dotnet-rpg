using dotnet_rpg.Dtos.Character;
using dotnet_rpg.Models;
using dotnet_rpg.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
    private readonly ICharacterService _characterService;

    public CharacterController(ICharacterService characterService){
        _characterService = characterService;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<ServiceResponse<List<Character>>>> Get() {
        return Ok(await _characterService.GetAllCharacters());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceResponse<Character>>> GetSingle(Guid id) {
        return Ok(await _characterService.GetCharacterById(id));
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacter(AddCharacterDto newCharacter){
        return Ok(await _characterService.AddCharacter(newCharacter));
    }

    [HttpPut]
    public async Task<ActionResult<ServiceResponse<Character>>> UpdateCharacter(UpdateCharacterDto updatedCharacter){
        var response = await _characterService.UpdateCharacter(updatedCharacter);
        if (response.Data is null)
            return NotFound(response);
        else
            return Ok(response);
    }

    [HttpDelete]
    public async Task<ActionResult<ServiceResponse<List<Character>>>> DeleteCharacter(Guid id){

        var response = await _characterService.DeleteCharacter(id);
        if (response.Data is null){
            return NotFound(response);
        }
        else{
            return Ok(response);
        }

    }

}