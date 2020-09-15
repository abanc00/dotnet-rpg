using System.Threading.Tasks;
using dotnet_rpg.Dtos.AddCharacterSkill;
using dotnet_rpg.Dtos.Character;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterSkillService
{
    public interface ICharacterSkillService
    {
         Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}