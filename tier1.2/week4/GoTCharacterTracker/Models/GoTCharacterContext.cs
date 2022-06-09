using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace GoTCharacterTracker.Models
{
    public class GoTCharacterContext : DbContext
    {
        //public GoTCharacterContext(DbContextOptions<GoTCharacterContext> options)
        //    : base(options)
        //{
        //}

        public DbSet<GoTCharacter> goTCharacters { get; set; } = null!;

        public string DbPath { get; }

        public GoTCharacterContext(DbContextOptions<GoTCharacterContext> options)
            : base(options)
        {
            //var folder = Environment.SpecialFolder.LocalApplicationData;
            //var path = Environment.GetFolderPath(folder);
            //DbPath = System.IO.Path.Join(path, "blogging.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}


