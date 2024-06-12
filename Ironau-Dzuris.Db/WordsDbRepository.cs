using Ironau_Dzuris.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ironau_Dzuris.Db
{
    public class WordsDbRepository : IWordsRepository
    {
        private readonly DatabaseContext databaseContext;

        public WordsDbRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public List<Word> GetWords()
        {
            return databaseContext.Words.ToList();
        }

        public Word GetRandomWord()
        {
            Random random = new Random();
            int rndIndex = random.Next(0, databaseContext.Words.Count());
            return databaseContext.Words.ToList()[rndIndex];
        }

        public List<Word> GetWrongWords(Guid right_id)
        {
            Random random = new Random();
            HashSet<Guid> selectedWordIds = new HashSet<Guid>();
            List<Word> wrongWords = new List<Word>();

            while (wrongWords.Count < 5)
            {
                int rndIndex = random.Next(0, databaseContext.Words.Count());
                Word randomWord = databaseContext.Words.ToList()[rndIndex];

                if (!selectedWordIds.Contains(randomWord.Id) && randomWord.Id != right_id)
                {
                    wrongWords.Add(randomWord);
                    selectedWordIds.Add(randomWord.Id);
                }
            }

            return wrongWords;
        }

    }

    public interface IWordsRepository
    {
        List<Word> GetWords();
        public Word GetRandomWord();
        public List<Word> GetWrongWords(Guid right_id);
    }
}
