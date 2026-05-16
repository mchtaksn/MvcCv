using Microsoft.AspNetCore.Mvc;
using MvcDB.Models;
using MvcDB.Repositories;

namespace MvcDB.Controllers
{
    public class Admin : Controller
    {
        GenericRepositery<Tbladmin> repo = new GenericRepositery<Tbladmin>();
        public IActionResult Index()
        {
            var liste = repo.List();
            return View(liste);
        }
        [HttpGet]
        public ActionResult adminekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult adminekle(Tbladmin p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult adminsil(int id)
        {
            Tbladmin t = repo.Find(x => x.Id == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult admindüzenle(int id)
        {
            Tbladmin t = repo.Find(x => x.Id == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult admindüzenle(Tbladmin p)
        {
            Tbladmin t = repo.Find(x => x.Id == p.Id);
            t.Kullaniciadi = p.Kullaniciadi;
            t.Sifre = p.Sifre;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}
    