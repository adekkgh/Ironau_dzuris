using Ironau_Dzuris.Db.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ironau_Dzuris.Db
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

            modelBuilder.Entity<Phrase>().HasData(new List<Phrase>()
            {
                new Phrase()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000001"),
                    Theme = "Без темы",
                    Phrase_ru = "Как тебя зовут?",
                    Phrase_os = "Дæ ном куыд у?"
                },
                new Phrase()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000002"),
                    Theme = "Без темы",
                    Phrase_ru = "Доброе утро",
                    Phrase_os = "Дæ(Уæ) рáйсом хорз"
                },
                new Phrase()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000003"),
                    Theme = "Без темы",
                    Phrase_ru = "Добрый вечер",
                    Phrase_os = "Дæ и́зæр хорз"
                },
                new Phrase()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000004"),
                    Theme = "Без темы",
                    Phrase_ru = "Добрый день",
                    Phrase_os = "Дæ бон хорз"
                },
                new Phrase()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000005"),
                    Theme = "Без темы",
                    Phrase_ru = "Спокойной ночи",
                    Phrase_os = "Хæрхǽхсæв"
                },
                new Phrase()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000006"),
                    Theme = "Без темы",
                    Phrase_ru = "Да",
                    Phrase_os = "О"
                },
                new Phrase()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000007"),
                    Theme = "Без темы",
                    Phrase_ru = "Нет",
                    Phrase_os = "Нæ"
                },
                new Phrase()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000008"),
                    Theme = "Без темы",
                    Phrase_ru = "Хорошо",
                    Phrase_os = "Хорз"
                },
                new Phrase()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000009"),
                    Theme = "Без темы",
                    Phrase_ru = "Спасибо",
                    Phrase_os = "Бузныг"
                },
                new Phrase()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000010"),
                    Theme = "Без темы",
                    Phrase_ru = "Большое спасибо",
                    Phrase_os = "Стыр Бузныг"
                },
            });
        }
    }
}
