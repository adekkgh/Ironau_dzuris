using Look_For_It.Db.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Look_For_It.Db
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Phrase> Phrases { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = new Guid("00000000-aaaa-aaaa-aaaa-000000000000"),
                Name = "admin",
                Email = "admin@admin.ru",
                Password = "aDMiN"

            });
        }
    }
}
