using Microsoft.AspNetCore.Mvc;
using MvcDB.Models;
using MvcDB.Repositories;
namespace MvcDB.Controllers
{
    public class Hobilerim : Controller
    {
        GenericRepositery<Tblhobilerim> repo = new GenericRepositery<Tblhobilerim> ();
        [HttpGet]
        public IActionResult Index()
        {
            var hobi = repo.List();
            return View(hobi);
        }
        [HttpPost]
        public IActionResult Index(Tblhobilerim p)
        {
            //Tblhobilerim t = new Tblhobilerim ();
            var t = repo.Find(x=>x.Id == 1);
            t.Aciklama= p.Aciklama;
            t.Aciklama2 = p.Aciklama2;
            repo.TUpdate (t);
            return RedirectToAction("Index");
        }


    }
}
