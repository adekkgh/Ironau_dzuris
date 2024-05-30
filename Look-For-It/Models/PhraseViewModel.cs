using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Look_For_It.Models
{
    public class PhraseViewModel
    {
        public string Theme { get; set; }

        [Required(ErrorMessage = "Введите значение фразы на русском языке")]
        public string Phrase_ru {  get; set; }

        [Required(ErrorMessage = "Введите значение фразы на осетинском языке")]
        public string Phrase_os { get; set; }

    }
}
