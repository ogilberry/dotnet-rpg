using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Dtos.Weapon
{
    public class AddWeaponDto
    {
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; }
        public Guid CharacterId { get; set; }
    }
}