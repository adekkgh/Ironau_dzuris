using Ironau_Dzuris.Db;
using Ironau_Dzuris.Db.Models;
using Ironau_Dzuris.Helpers;
using Ironau_Dzuris.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Ironau_Dzuris.Controllers
{
    public class GameController : Controller
    {
        private readonly IPhraseRepository phraseRepository;
        private readonly IWordsRepository wordsRepository;
        private static string rightAnswer;

        public GameController(IPhraseRepository phraseRepository, IWordsRepository wordsRepository)
        {
            this.phraseRepository = phraseRepository;
            this.wordsRepository = wordsRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PhraseGame()
        {
            if (Request.Cookies["user"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(GeneratePhrases());
        }

        public List<PhraseViewModel> GeneratePhrases()
        {
            Random random = new Random();
            List<Phrase> answers = new List<Phrase>();
            var currentPhrase = phraseRepository.GetRandomPhrase();
            var wrongAnswers = phraseRepository.GetWrongPhrases(currentPhrase.Id);
            answers.Add(currentPhrase);
            answers.Add(wrongAnswers[0]);
            answers.Add(wrongAnswers[1]);

            ViewData["phrase"] = Mapping.PhraseToViewModel(currentPhrase);
            rightAnswer = Mapping.PhraseToViewModel(currentPhrase).Phrase_os;
            return Mapping.AllPhrasesToViewModel(answers.OrderBy(a => random.Next()).ToList());
        }

        public IActionResult Answer()
        {
            return Json(rightAnswer);
        }

        public IActionResult WordsGame()
        {
            if (Request.Cookies["user"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(GenerateWords());
        }

        public List<WordViewModel> GenerateWords()
        {
            Random random = new Random();
            List<Word> answers = new List<Word>();
            var currentWord = wordsRepository.GetRandomWord();
            var wrongWords = wordsRepository.GetWrongWords(currentWord.Id);
            answers.Add(currentWord);
            foreach(var wrongWord in wrongWords)
            {
                answers.Add(wrongWord);
            }

            ViewData["word"] = Mapping.WordToViewModel(currentWord);
            rightAnswer = Mapping.WordToViewModel(currentWord).Word_ru;

            return Mapping.AllWordsToViewModel(answers.OrderBy(a => random.Next()).ToList());
        }
    }
}
