using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Dtos.Character
{
    public class AddCharacterSkillDto
    {
        public Guid CharacterId { get; set; }
        public Guid SkillId { get; set; }
    }
}