using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Ironau_Dzuris.Models
{
    public class PhraseViewModel
    {
        public Guid Id { get; set; }
        public string Theme { get; set; }

        [Required(ErrorMessage = "Введите значение фразы на русском языке")]
        public string Phrase_ru {  get; set; }

        [Required(ErrorMessage = "Введите значение фразы на осетинском языке")]
        public string Phrase_os { get; set; }

    }
}
