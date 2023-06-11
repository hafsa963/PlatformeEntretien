using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlatformeEntretien.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace PlatformeEntretien.Controllers

{
    public class SpaceAdmin : Controller
    {
        private readonly Connexion _context;

        public object ModelState { get; private set; }

        public SpaceAdmin(Connexion context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult admin()
        {
            return View();
        }
        public ActionResult OnGetDelete(int id)
        {
            this.ContextId = _context.ContextId.Single(c => c.ID == id);
            _context.ContextId.Remove(this.ContextId);
            _context.SaveChanges();
            this.ContextId = _context.ContextId.ToList();
            return new JsonResult(new { success = true, message = "La Suppretion de Candidat a etais effectue avec success!", statutcolis = this.id });

        }






    }


}



