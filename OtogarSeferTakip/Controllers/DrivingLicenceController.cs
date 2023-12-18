using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OtogarSeferTakip.Entities;
using OtogarSeferTakip.Models;

namespace OtogarSeferTakip.Controllers
{
    
        public class DrivingLicenceController : Controller
        {
            private readonly DatabaseContext _databaseContext;
            private readonly IMapper _mapper;

            public DrivingLicenceController(DatabaseContext databaseContext, IMapper mapper)
            {
                _databaseContext = databaseContext;
                _mapper = mapper;
            }

            public IActionResult Index()
            {
                return View();
            }
            public IActionResult DrivingLicenceListPartial()
            {
                var result = _databaseContext.DrivingLicenses.ToList();
                return PartialView("_DrivingLicenceListPartial", result);
            }
            //public IActionResult Delete(int id)
            //{
            //    DrivingLicence tako = _databaseContext.Takos.Find(id);
            //    if (tako != null)
            //    {
            //        _databaseContext.Remove(tako);
            //        _databaseContext.SaveChanges();

            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            public IActionResult AddNewDrivingLicencePartial()
            {
                return PartialView("_AddNewDrivingLicencePartial", new DrivingLicenceModel());
            }

            [HttpPost]
            public IActionResult AddNewDrivingLicence(DrivingLicenceModel model)
            {
                if (ModelState.IsValid)
                {
                    DrivingLicence drivingLicence = _mapper.Map<DrivingLicence>(model);

                    _databaseContext.DrivingLicenses.Add(drivingLicence);
                    _databaseContext.SaveChanges();


                    return PartialView("_AddNewDrivingLicencePartial", new DrivingLicenceModel { Done = "Eklendi." });

                }

                return PartialView("_AddNewDrivingLicencePartial", model);
            }
            public IActionResult EditDrivingLicencePartial(int id)
            {
                DrivingLicence drivingLicence = _databaseContext.DrivingLicenses.Find(id);
                DrivingLicenceModel model = _mapper.Map<DrivingLicenceModel>(drivingLicence);

                return PartialView("_EditDrivingLicencePartial", model);
            }

            [HttpPost]
            public IActionResult EditDrivingLicence(int id, TakoModel model)
            {
                if (ModelState.IsValid)
                {
                    DrivingLicence drivingLicence = _databaseContext.DrivingLicenses.Find(id);
                    _mapper.Map(model, drivingLicence);

                    _databaseContext.SaveChanges();

                    return PartialView("_EditDrivingLicencePartial", new DrivingLicenceModel { Done = "Düzenlendi." });
                }


                return PartialView("_EditDrivingLicencePartial", model);
            }
        }
    
}
