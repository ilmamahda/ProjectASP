using Microsoft.AspNetCore.Mvc;
using ProjectASP.Models;
using ProjectASP.Repositories;
using ProjectASP.ViewModels;

namespace ProjectASP.Controllers
{
    public class PenggajianController : Controller
    {
        private readonly IPenggajianRepostory _penggajianRepostory;

        public PenggajianController(IPenggajianRepostory penggajianRepostory)
        {
            _penggajianRepostory = penggajianRepostory;
        }

        [HttpGet]
        public async Task<ViewResult> Index()
        {
            var user = new PenggajianViewModel();
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Index(PenggajianViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var emp = new Penggajian
                {
                    GajiId = viewModel.GajiId,
                    EmployeeNumber = viewModel.EmployeeNumber,
                    FullName = viewModel.FullName,
                    Nominal = viewModel.Nominal
                };
                var result = _penggajianRepostory.GetAllPenggajian().Where(c => c.FullName == emp.FullName).FirstOrDefault();
                if (result == null)
                {
                    _penggajianRepostory.Tambah(emp);
                    return View(result);
                }
            }
            return View(viewModel);
        }

        public IActionResult Read()
        {
            var data = _penggajianRepostory.GetAllPenggajian();
            return View(data);
        }
    }
}
