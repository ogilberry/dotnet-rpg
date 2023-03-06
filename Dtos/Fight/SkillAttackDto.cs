using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Dtos.Fight
{
    public class SkillAttackDto
    {
        public Guid AttackerId { get; set; }
        public Guid OpponentId { get; set; }    
        public Guid SkillId { get; set; }
    }
}