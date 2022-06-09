using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ApiAppGot2.Models
{
    public class GoTCharacterContext : DbContext
    {
        public GoTCharacterContext(DbContextOptions<GoTCharacterContext> options)
            : base(options)
        {
        }

        public DbSet<GoTCharacter> goTCharacters { get; set; } = null!;
    }
}
