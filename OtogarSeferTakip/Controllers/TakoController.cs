using Microsoft.AspNetCore.Mvc;
using OtogarSeferTakip.Entities;
using OtogarSeferTakip.Models;

namespace OtogarSeferTakip.Controllers
{
    public class TakoController : Controller
    {
        private readonly DatabaseContext _databaseContext;

        public TakoController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IActionResult Index()
        {
           var result = _databaseContext.Takos.ToList();
            return View(result);
        }
        //public IActionResult Delete(int id)
        //{
        //    Tako tako = _databaseContext.Takos.Find(id);
        //    if (tako != null)
        //    {
        //        _databaseContext.Remove(tako);
        //        _databaseContext.SaveChanges();

        //    }
        //    return RedirectToAction(nameof(Index));
        //}
        public IActionResult Add()
        {         
            return View();
        }

        [HttpPost]
        public IActionResult Add(Tako tako)
        {
            if (ModelState.IsValid)
            {
                _databaseContext.Takos.Add(tako);      
                _databaseContext.SaveChanges();
                TempData["Message"] = "Takograf Ekleme Başarılı.";

            }
            else
            {
                TempData["ErrorMessage"] = "Başarısız.";
                ModelState.AddModelError(nameof(tako.TakoName), "Hata.");
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(Tako id)
        {
            Tako tako = _databaseContext.Takos.Find(id);
            return View(tako);
        }

        [HttpPost]
        public IActionResult Edit(Tako tako, int id)
        {
            if (ModelState.IsValid)
            {
                var existingTako = _databaseContext.Takos.Find(id);


                _databaseContext.SaveChanges();
                TempData["Message"] = "Takograf Düzenlendi.";
            }


            return RedirectToAction(nameof(Index));
        }
    }
}
