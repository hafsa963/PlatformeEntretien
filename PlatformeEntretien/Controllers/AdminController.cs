using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlatformeEntretien.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace PlatformeEntretien.Controllers

{
    public class AdminController : Controller
    {
        private readonly Connexion _context;

        public object ModelState { get; private set; }

        public AdminController(Connexion context)
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
      

     



        // [HttpPost]
        /*
       public IActionResult Create(Candidat Admin)
       {
           /*  if (ModelState.IsValid)
             {
                 _context.candidats.Add(Admin);
                 _context.SaveChanges();

                 return RedirectToAction("Index", "admin"); // Redirect to home page after successful submission
             }

           return View(Admin);

       }*/

        /* private IActionResult RedirectToAction(string v1, string v2)
         {
             throw new NotImplementedException();
         }

         private IActionResult View(Candidat admin)
         {
             throw new NotImplementedException();
         }
        }*/
         
 
    

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
         
            bool isAuthenticated = _context.Users.Any(u => u.admin_ == username && u.motdepass == password);

            if (isAuthenticated)
            {
                 
                return RedirectToAction("Index", "Candidature");
            }
            else
            {
               
                return View(".");
            }
        }
    }


}



