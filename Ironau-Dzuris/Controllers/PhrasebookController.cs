using Ironau_Dzuris.Db;
using Microsoft.AspNetCore.Mvc;
using Ironau_Dzuris.Helpers;
using Ironau_Dzuris.Db.Models;
using Ironau_Dzuris.Models;
using System;

namespace Ironau_Dzuris.Controllers
{
    public class PhrasebookController : Controller
    {
        private readonly IPhraseRepository phraseRepository;

        public PhrasebookController(IPhraseRepository phraseRepository)
        {
            this.phraseRepository = phraseRepository;
        }

        public IActionResult Index()
        {
            return View(Mapping.AllPhrasesToViewModel(phraseRepository.GetPhrases()));
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult CreatePhrase(string theme, string phrase_ru, string phrase_os)
        {
            if (Request.Cookies["user"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var newPhrase = new Phrase
            {
                Theme = theme,
                Phrase_ru = phrase_ru,
                Phrase_os = phrase_os
            };
            phraseRepository.Add(newPhrase);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(Guid phraseId)
        {
            if (Request.Cookies["user"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var phrase = phraseRepository.TryGetById(phraseId);
            return View(Mapping.PhraseToViewModel(phrase));
        }

        public IActionResult ChangePhrase(PhraseViewModel changedPhrase)
        {
            if (Request.Cookies["user"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            phraseRepository.Edit(Mapping.ViewModelToPhrase(changedPhrase));
            return RedirectToAction("Index");
        }
    }
}
