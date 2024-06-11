using Ironau_Dzuris.Db;
using Ironau_Dzuris.Db.Models;
using Ironau_Dzuris.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

namespace Ironau_Dzuris.Helpers
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

        public static UserViewModel UserToUserViewModel(User user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                Role = user.Role,
            };
        }
    }
}
