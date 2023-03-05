using System.Security.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Data;
using dotnet_rpg.Dtos.Character;
using dotnet_rpg.Dtos.Weapon;
using dotnet_rpg.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace dotnet_rpg.Services.WeaponService
{
    public class WeaponService : IWeaponService
    {

        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public WeaponService(DataContext context, IHttpContextAccessor httpContextAccessor, IMapper mapper){
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon)
        {
            var response = new ServiceResponse<GetCharacterDto>();
            try{
                var character = await _context.Characters
                    .FirstOrDefaultAsync(c => c.Id == newWeapon.CharacterId
                        && c.User!.Id == Guid.Parse(_httpContextAccessor.HttpContext!.User
                        .FindFirstValue(ClaimTypes.NameIdentifier)!));

                if (character is null){
                    response.Success = false;
                    response.Message = "Character not found.";
                    return response;
                }

                var weapon = new Weapon{
                    Name = newWeapon.Name,
                    Damage = newWeapon.Damage,
                    Character = character
                };

                _context.Weapons.Add(weapon);
                await _context.SaveChangesAsync();

                response.Data = _mapper.Map<GetCharacterDto>(character);
            }
            catch (Exception e){
                response.Message = e.Message;
                response.Success = false;
            }

            return response;
        }
    }
}