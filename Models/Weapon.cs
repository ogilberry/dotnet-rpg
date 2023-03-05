using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Models
{
    public class Weapon
    {
        public Guid Id { get; set; }
        public String Name { get; set; } = string.Empty;
        public int Damage { get; set; }
        public Character? Character { get; set; }
        public Guid CharacterId { get; set; }
    }
}