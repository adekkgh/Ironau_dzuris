using Look_For_It.Db;
using Look_For_It.Db.Models;
using Look_For_It.Helpers;
using Look_For_It.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Look_For_It.Controllers
{
    public class GameController : Controller
    {
        private readonly IPhraseRepository phraseRepository;
        private static string rightAnswer;

        public GameController(IPhraseRepository phraseRepository)
        {
            this.phraseRepository = phraseRepository;
        }

        public IActionResult Index()
        {
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
    }
}
