using Microsoft.AspNetCore.Mvc;
using MvcDB.Models;
using MvcDB.Repositories;

namespace MvcDB.Controllers
{
    public class Deneyim : Controller
    {
        DeneyimRepository repo = new DeneyimRepository();
        public IActionResult Index()
        {
            var deneyim=repo.List();
            return View(deneyim);
        }
        [HttpGet]
        public ActionResult deneyimekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult deneyimekle(Tbldeneyimlerim p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult deneyimsil(int id)
        {
            Tbldeneyimlerim t = repo.Find(x=>x.Id == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeneyimGetir(int id)
        {
            Tbldeneyimlerim t = repo.Find(x => x.Id == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult DeneyimGetir(Tbldeneyimlerim p)
        {
            Tbldeneyimlerim t = repo.Find(x => x.Id == p.Id);
            t.Baslik=p.Baslik;
            t.Altbaslik=p.Altbaslik;
            t.Tarih=p.Tarih;
            t.Aciklama=p.Aciklama;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}
