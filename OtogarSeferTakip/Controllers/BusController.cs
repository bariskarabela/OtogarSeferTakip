using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OtogarSeferTakip.Entities;
using OtogarSeferTakip.Models;

namespace OtogarSeferTakip.Controllers
{
    public class BusController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private readonly IMapper _mapper;

        public BusController(DatabaseContext databaseContext, IMapper mapper)
        {
            _databaseContext = databaseContext;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BusListPartial()
        {
            var result = _databaseContext.Buses.Include(bus => bus.Tako).ToList();

            return PartialView("_BusListPartial", result);
        }
        //public IActionResult Delete(int id)
        //{
        //    Bus tako = _databaseContext.Buss.Find(id);
        //    if (tako != null)
        //    {
        //        _databaseContext.Remove(tako);
        //        _databaseContext.SaveChanges();

        //    }
        //    return RedirectToAction(nameof(Index));
        //}
        public IActionResult AddNewBusPartial()
        {
            return PartialView("_AddNewBusPartial", new BusCustomModel());
        }

        [HttpPost]
        public IActionResult AddNewBus(BusCustomModel model)
        {
            if (ModelState.IsValid)
            {
                Bus tako = _mapper.Map<Bus>(model);

                _databaseContext.Buses.Add(tako);
                _databaseContext.SaveChanges();


                return PartialView("_AddNewBusPartial", new BusCustomModel { Done = "Eklendi." });

            }

            return PartialView("_AddNewBusPartial", model);
        }
        public IActionResult EditBusPartial(int id)
        {
            Bus tako = _databaseContext.Buses.Find(id);
            BusCustomModel model = _mapper.Map<BusCustomModel>(tako);

            return PartialView("_EditBusPartial", model);
        }

        [HttpPost]
        public IActionResult EditBus(int id, BusCustomModel model)
        {
            if (ModelState.IsValid)
            {
                Bus tako = _databaseContext.Buses.Find(id);
                _mapper.Map(model, tako);

                _databaseContext.SaveChanges();

                return PartialView("_EditBusPartial", new BusCustomModel { Done = "Düzenlendi." });
            }


            return PartialView("_EditBusPartial", model);
        }
    }
}
