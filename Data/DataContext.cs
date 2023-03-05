using dotnet_rpg.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_rpg.Data;

public class DataContext : DbContext{

    public DataContext (DbContextOptions<DataContext> options) : base(options){

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        
        // create a pool of Skill rows for characters to use
        modelBuilder.Entity<Skill>().HasData(
            new Skill {Id = Guid.NewGuid(), Name = "Devastating Rhyme", Damage = 5},
            new Skill {Id = Guid.NewGuid(), Name = "Super Serious Punch", Damage = 20},
            new Skill {Id = Guid.NewGuid(), Name = "Force Lightning", Damage = 10}
        );

    }

    public DbSet<Character> Characters => Set<Character>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Weapon> Weapons => Set<Weapon>();
    public DbSet<Skill> Skills => Set<Skill>();

}