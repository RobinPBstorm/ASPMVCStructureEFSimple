using Microsoft.AspNetCore.Mvc;
using StructrureEFSimple.BLL.Services.Interfaces;
using StructrureEFSimple.Mapper;
using StructrureEFSimple.Models;
using StructureEFSimple.BLL.Models.Exceptions;

namespace StructrureEFSimple.Controllers
{
    public class PersonneController : Controller
    {
        private readonly IPersonneService _service;
        public PersonneController(IPersonneService service)
        {
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
            catch (PersonneNotFoundException pnfe)
            {
                TempData["Message"] = pnfe.Message;
                return RedirectToAction(nameof(PersonneController.Index));
            }
        }
    }
}
