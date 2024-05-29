using Look_For_It.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Look_For_It.Db
{
    public class PhrasesDbRepository : IPhraseRepository
    {
        private readonly DatabaseContext databaseContext;

        public PhrasesDbRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public List<Phrase> GetPhrases()
        {
            return databaseContext.Phrases.ToList();
        }

        public void Add(Phrase phrase)
        {
            databaseContext.Phrases.Add(phrase);
            databaseContext.SaveChanges();
        }
    }

    public interface IPhraseRepository
    {
        public List<Phrase> GetPhrases();
        public void Add(Phrase phrase);
    }
}
