using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OtogarSeferTakip.Entities;
using OtogarSeferTakip.Models;

namespace OtogarSeferTakip.Controllers
{
    public class TakoController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private readonly IMapper _mapper;

        public TakoController(DatabaseContext databaseContext, IMapper mapper)
        {
            _databaseContext = databaseContext;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TakoListPartial()
        {
            var result = _databaseContext.Takos.ToList();
            return PartialView("_TakoListPartial",result);
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
        public IActionResult AddNewTakoPartial()
        {         
            return PartialView("_AddNewTakoPartial", new TakoModel());
        }

        [HttpPost]
        public IActionResult AddNewTako(TakoModel model)
        {
            if (ModelState.IsValid)
            {
                Tako tako = _mapper.Map<Tako>(model);

                _databaseContext.Takos.Add(tako);      
                _databaseContext.SaveChanges();

        
                return PartialView("_AddNewTakoPartial", new TakoModel { Done = "Eklendi." });

            }

            return PartialView("_AddNewTakoPartial", model);
        }
        public IActionResult EditTakoPartial(int id)
        {
            Tako tako = _databaseContext.Takos.Find(id);
            TakoModel model = _mapper.Map<TakoModel>(tako);

            return PartialView("_EditTakoPartial", model);
        }

        [HttpPost]
        public IActionResult EditTako(int id,TakoModel model)
        {
            if (ModelState.IsValid)
            {
                Tako tako = _databaseContext.Takos.Find(id);
                _mapper.Map(model,tako);

                _databaseContext.SaveChanges();
    
                return PartialView("_EditTakoPartial", new TakoModel { Done = "Düzenlendi." });
            }
          

            return PartialView("_EditTakoPartial", model);
        }
    }
}
