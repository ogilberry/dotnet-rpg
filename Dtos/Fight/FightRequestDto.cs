using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Dtos.Fight
{
    public class FightRequestDto
    {
        public List<Guid> CharacterIds { get; set; } = new List<Guid>();
    }
}