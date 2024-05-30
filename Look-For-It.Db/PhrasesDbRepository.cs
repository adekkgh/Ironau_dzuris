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

        public Phrase GetRandomPhrase()
        {
            Random random = new Random();
            int rndIndex = random.Next(0, databaseContext.Phrases.Count());
            return databaseContext.Phrases.ToList()[rndIndex];
        }

        public List<Phrase> GetWrongPhrases(Guid right_id)
        {
            Random random = new Random();
            Phrase wrong_phrase_1;
            Phrase wrong_phrase_2;

            while (true)
            {
                int rndIndex_1 = random.Next(0, databaseContext.Phrases.Count());
                int rndIndex_2 = random.Next(0, databaseContext.Phrases.Count());
                wrong_phrase_1 = databaseContext.Phrases.ToList()[rndIndex_1];
                wrong_phrase_2 = databaseContext.Phrases.ToList()[rndIndex_2];
                if ( (wrong_phrase_1.Id != wrong_phrase_2.Id) && (wrong_phrase_1.Id != right_id) && (wrong_phrase_2.Id != right_id) )
                {
                    break;
                }
            }

            return new List<Phrase>
            {
                wrong_phrase_1,
                wrong_phrase_2
            };
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
        public Phrase GetRandomPhrase();
        public List<Phrase> GetWrongPhrases(Guid right_id);
    }
}
