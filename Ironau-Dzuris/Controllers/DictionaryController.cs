using Ironau_Dzuris.Db.Models;
using Ironau_Dzuris.Db;
using Ironau_Dzuris.Helpers;
using Ironau_Dzuris.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Ironau_Dzuris.Controllers
{
    public class DictionaryController : Controller
    {
        private readonly IWordsRepository wordsRepository;

        public DictionaryController(IWordsRepository wordsRepository)
        {
            this.wordsRepository = wordsRepository;
        }

        public IActionResult Index()
        {
            return View(Mapping.AllWordsToViewModel(wordsRepository.GetWords()));
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult CreateWord(string theme, string word_ru, string word_os)
        {
            if (Request.Cookies["user"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var newWord = new Word
            {
                Theme = theme,
                Word_ru = word_ru,
                Word_os = word_os
            };
            wordsRepository.Add(newWord);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(Guid wordId)
        {
            if (Request.Cookies["user"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var word = wordsRepository.TryGetById(wordId);
            return View(Mapping.WordToViewModel(word));
        }

        public IActionResult ChangeWord(WordViewModel changedWord)
        {
            if (Request.Cookies["user"] == null)
            {
                return RedirectToAction("Index", "Home");
            }

            wordsRepository.Edit(Mapping.ViewModelToWord(changedWord));
            return RedirectToAction("Index");
        }
    }
}
