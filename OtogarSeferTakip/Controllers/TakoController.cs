using Microsoft.AspNetCore.Mvc;
using OtogarSeferTakip.Entities;

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
           result = _databaseContext.();
            return View(result);
        }
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
            }
            return View(nameof(Add));
        }
    }
}
