using Microsoft.AspNetCore.Mvc;
using ProjectASP.Models;
using ProjectASP.Repositories;
using ProjectASP.ViewModels;

namespace ProjectASP.Controllers
{
    public class KaryawanController : Controller
    {
        private readonly IKaryawanRepository _karyawanRepository;

        public KaryawanController(IKaryawanRepository karyawanRepository)
        {
            _karyawanRepository = karyawanRepository;
        }
        //public IActionResult Index()
        //{
        //    var data = _karyawanRepository.GetAllKaryawan();
        //    return View(data);
        //}

        [HttpGet]
        public async Task<ViewResult> Index()
        {
            var user = new KaryawanViewModel();
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Index(KaryawanViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var emp = new Karyawan
                {
                    EmployeeId = viewModel.EmployeeId,
                    EmployeeNumber = viewModel.EmployeeNumber,
                    FullName = viewModel.FullName,
                    Gender = viewModel.Gender,
                    Address = viewModel.Address,
                    Handphone = viewModel.Handphone,
                    Email = viewModel.Email,
                    Note = viewModel.Note
                };
                var result = _karyawanRepository.GetAllKaryawan().Where(c => c.FullName == emp.FullName).FirstOrDefault();
                if (result == null)
                {
                    _karyawanRepository.Tambah(emp);
                    return View(result);
                }
            }
            return View(viewModel);
        }
        public IActionResult Read()
        {
            var data = _karyawanRepository.GetAllKaryawan();
            return View(data);
        }
    }
}
