using dotnet_rpg.Models;
namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        
        Task<ServiceResponse<List<Character>>> GetAllCharacters();

        Task<ServiceResponse<Character>> GetCharacterById(Guid id);

        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);

    }
}