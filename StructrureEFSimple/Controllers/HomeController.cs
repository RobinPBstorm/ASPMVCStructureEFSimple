using Microsoft.AspNetCore.Mvc;
using StructrureEFSimple.Mapper;
using StructrureEFSimple.Models;
using StructrureEFSimple.BLL.Services.Interfaces;
using System.Diagnostics;
using StructureEFSimple.BLL.Models.Exceptions;

namespace StructrureEFSimple.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPersonneService _service;
        public HomeController(ILogger<HomeController> logger, IPersonneService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            List<PersonneViewModel> personnes = _service.GetAll()
                                                        .Select(p => p.toViewModel())
                                                        .ToList();
            return View(personnes);
        }

        public IActionResult Details(int id)
        {
            try
            {
                PersonneViewModel personne = _service.GetOneById(id).toViewModel();

                return View(personne);
            }
            catch(PersonneNotFoundException pnfe)
            {
                TempData["Message"] = pnfe.Message;
                return RedirectToAction(nameof(HomeController.Index));
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
