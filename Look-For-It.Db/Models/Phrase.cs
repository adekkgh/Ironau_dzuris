using System;
using System.Collections.Generic;
using System.Text;

namespace Look_For_It.Db.Models
{
    public class Phrase
    {
        public Guid Id { get; set; }
        public string Theme { get; set; }
        public string Phrase_ru { get; set; }
        public string Phrase_os { get; set; }

    }
}
