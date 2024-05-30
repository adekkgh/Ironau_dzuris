using Look_For_It.Db;
using Look_For_It.Db.Models;
using Look_For_It.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

namespace Look_For_It.Helpers
{
    public static class Mapping
    {
        public static PhraseViewModel PhraseToViewModel(Phrase phrase)
        {
            return new PhraseViewModel
            {
                Theme = phrase.Theme,
                Phrase_ru = phrase.Phrase_ru,
                Phrase_os = phrase.Phrase_os,
            };
        }

        public static List<PhraseViewModel> AllPhrasesToViewModel(List<Phrase> phrases)
        {
            return phrases.Select(phrase => PhraseToViewModel(phrase)).ToList();
        }
    }
}
