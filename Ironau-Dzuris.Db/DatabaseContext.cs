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

        public DbSet<Word> Words { get; set; }

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
                Password = "aDMiN",
                Role = "admin"

            });

            modelBuilder.Entity<Phrase>().HasData(new List<Phrase>()
            {
                new Phrase()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000001"),
                    Theme = "Общение",
                    Phrase_ru = "Как тебя зовут?",
                    Phrase_os = "Дæ ном куыд у?"
                },
                new Phrase()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000002"),
                    Theme = "Общение",
                    Phrase_ru = "Доброе утро",
                    Phrase_os = "Дæ(Уæ) рáйсом хорз"
                },
                new Phrase()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000003"),
                    Theme = "Общение",
                    Phrase_ru = "Добрый вечер",
                    Phrase_os = "Дæ и́зæр хорз"
                },
                new Phrase()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000004"),
                    Theme = "Общение",
                    Phrase_ru = "Добрый день",
                    Phrase_os = "Дæ бон хорз"
                },
                new Phrase()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000005"),
                    Theme = "Общение",
                    Phrase_ru = "Спокойной ночи",
                    Phrase_os = "Хæрзǽхсæв"
                },
                new Phrase()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000006"),
                    Theme = "Общение",
                    Phrase_ru = "Да",
                    Phrase_os = "О"
                },
                new Phrase()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000007"),
                    Theme = "Общение",
                    Phrase_ru = "Нет",
                    Phrase_os = "Нæ"
                },
                new Phrase()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000008"),
                    Theme = "Общение",
                    Phrase_ru = "Хорошо",
                    Phrase_os = "Хорз"
                },
                new Phrase()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000009"),
                    Theme = "Общение",
                    Phrase_ru = "Спасибо",
                    Phrase_os = "Бузныг"
                },
                new Phrase()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000010"),
                    Theme = "Общение",
                    Phrase_ru = "Большое спасибо",
                    Phrase_os = "Стыр Бузныг"
                },
            });

            modelBuilder.Entity<Word>().HasData(new List<Word>
            {
                new Word()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000001"),
                    Theme = "",
                    Word_ru = "Дерево",
                    Word_os = "Бæлас",
                    ImagePath = "/images/words/Дерево.jpg"
                },
                new Word()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000002"),
                    Theme = "",
                    Word_ru = "Мальчик",
                    Word_os = "Лæппу",
                    ImagePath = "/images/words/Мальчик.jpg"
                },
                new Word()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000003"),
                    Theme = "",
                    Word_ru = "Дом",
                    Word_os = "Хæдзар",
                    ImagePath = "/images/words/Дом.jpg"
                },
                new Word()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000004"),
                    Theme = "",
                    Word_ru = "Кот",
                    Word_os = "Гæды",
                    ImagePath = "/images/words/Кот.jpg"
                },
                new Word()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000005"),
                    Theme = "",
                    Word_ru = "Собака",
                    Word_os = "Куыдз",
                    ImagePath = "/images/words/Собака.jpg"
                },
                new Word()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000006"),
                    Theme = "",
                    Word_ru = "Стол",
                    Word_os = "Фынг",
                    ImagePath = "/images/words/Стол.jpg"
                },
                new Word()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000007"),
                    Theme = "",
                    Word_ru = "Книга",
                    Word_os = "Чиныг",
                    ImagePath = "/images/words/Книга.jpg"
                },
                new Word()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000008"),
                    Theme = "",
                    Word_ru = "Яблоко",
                    Word_os = "Фæткъуы",
                    ImagePath = "/images/words/Яблоко.jpg"
                },
                new Word()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000009"),
                    Theme = "",
                    Word_ru = "Мяч",
                    Word_os = "Пурти",
                    ImagePath = "/images/words/Мяч.jpg"
                },
                new Word()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000010"),
                    Theme = "",
                    Word_ru = "Солнце",
                    Word_os = "Хур",
                    ImagePath = "/images/words/Солнце.jpg"
                },
                new Word()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000011"),
                    Theme = "",
                    Word_ru = "Луна",
                    Word_os = "Мæй",
                    ImagePath = "/images/words/Луна.jpg"
                },
                new Word()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000012"),
                    Theme = "",
                    Word_ru = "Девочка",
                    Word_os = "Чызг",
                    ImagePath = "/images/words/Девочка.jpg"
                },
                new Word()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000013"),
                    Theme = "",
                    Word_ru = "Лопата",
                    Word_os = "Бел",
                    ImagePath = "/images/words/Лопата.jpg"
                },
                new Word()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000014"),
                    Theme = "",
                    Word_ru = "Вода",
                    Word_os = "Дон",
                    ImagePath = "/images/words/Вода.jpg"
                },
                new Word()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000015"),
                    Theme = "",
                    Word_ru = "Вишня",
                    Word_os = "Бал",
                    ImagePath = "/images/words/Вишня.jpg"
                },
                new Word()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000016"),
                    Theme = "",
                    Word_ru = "Рыба",
                    Word_os = "Кæсаг",
                    ImagePath = "/images/words/Рыба.jpg"
                },
                new Word()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000017"),
                    Theme = "",
                    Word_ru = "Огурец",
                    Word_os = "Джитъри",
                    ImagePath = "/images/words/Огурец.jpg"
                },
                new Word()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000018"),
                    Theme = "",
                    Word_ru = "Индюк",
                    Word_os = "Гогыз",
                    ImagePath = "/images/words/Индюк.jpg"
                },
                new Word()
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000019"),
                    Theme = "",
                    Word_ru = "Дверь",
                    Word_os = "Дуар",
                    ImagePath = "/images/words/Дверь.png"
                }
            });
        }
    }
}
