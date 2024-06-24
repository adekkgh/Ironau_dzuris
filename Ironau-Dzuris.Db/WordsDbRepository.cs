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

        public Word TryGetById(Guid id)
        {
            var word = databaseContext.Words.FirstOrDefault(w => w.Id == id);
            if (word == null) return null;

            return word;
        }

        public void Add(Word word)
        {
            databaseContext.Words.Add(word);
            databaseContext.SaveChanges();
        }

        public void Edit(Word changedWord)
        {
            var word = databaseContext.Words.FirstOrDefault(p => p.Id == changedWord.Id);
            word.Theme = changedWord.Theme;
            word.Word_ru = changedWord.Word_ru;
            word.Word_os = changedWord.Word_os;
            databaseContext.SaveChanges();
        }

    }

    public interface IWordsRepository
    {
        List<Word> GetWords();
        public Word GetRandomWord();
        public List<Word> GetWrongWords(Guid right_id);
        public Word TryGetById(Guid id);
        public void Add(Word word);
        public void Edit(Word changedWord);
    }
}
