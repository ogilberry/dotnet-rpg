using dotnet_rpg.Models;
namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
        
        Task<List<Character>> GetAllCharacters();

        Task<Character> GetCharacterById(Guid id);

        Task<List<Character>> AddCharacter(Character newCharacter);

    }
}