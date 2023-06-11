using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlatformeEntretien.Models;

namespace PlatformeEntretien.Controllers
{
    public class CandidatureController : Controller
    {
        private readonly Connexion _context;

        public CandidatureController(Connexion context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Candidature()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Candidat candidats)
        {
            if (ModelState.IsValid)
            {
                _context.candidats.Add(candidats);
                _context.SaveChanges();

                return RedirectToAction("Index", "Candidature"); // Redirect to home page after successful submission
            }

            return View(candidats);
        }

    }
}
