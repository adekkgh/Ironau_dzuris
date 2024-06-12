using System.ComponentModel.DataAnnotations;
using System;

namespace Ironau_Dzuris.Models
{
    public class WordViewModel
    {
        public Guid Id { get; set; }
        public string Theme { get; set; }

        [Required(ErrorMessage = "Введите значение слова на русском языке")]
        public string Word_ru { get; set; }

        [Required(ErrorMessage = "Введите значение слова на осетинском языке")]
        public string Word_os { get; set; }
        public string ImagePath { get; set; }
    }
}
