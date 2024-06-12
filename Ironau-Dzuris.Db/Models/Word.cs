using System;
using System.Collections.Generic;
using System.Text;

namespace Ironau_Dzuris.Db.Models
{
    public class Word
    {
        public Guid Id { get; set; }
        public string Theme { get; set; }
        public string Word_ru { get; set; }
        public string Word_os { get; set; }
        public string ImagePath { get; set; }
    }
}
