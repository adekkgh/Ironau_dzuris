using System;
using System.Collections.Generic;
using System.Text;

namespace Ironau_Dzuris.Db.Models
{
    public class Phrase
    {
        public Guid Id { get; set; }
        public string Theme { get; set; }
        public string Phrase_ru { get; set; }
        public string Phrase_os { get; set; }

    }
}
