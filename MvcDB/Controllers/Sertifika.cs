using Microsoft.AspNetCore.Mvc;
using MvcDB.Models;
using MvcDB.Repositories;

namespace MvcDB.Controllers
{
    public class Sertifika : Controller
    {
        GenericRepositery<Tblsertifikalarim> repo = new GenericRepositery<Tblsertifikalarim>();
        public IActionResult Index()
        {
            var deger = repo.List();
            return View(deger);
        }
        [HttpGet]
        public ActionResult sertifikagetir(int id)
        {
            var sertifika = repo.Find(x=>x.Id== id);
            ViewBag.d = id;
            return View(sertifika);
        }
        [HttpPost]
        public ActionResult sertifikagetir(Tblsertifikalarim p)
        {
            var sertifika = repo.Find(x => x.Id == p.Id);
           sertifika.Aciklama = p.Aciklama;
            repo.TUpdate(sertifika);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult yenisertifika()
        {
            return View();
        }
        [HttpPost]
        public ActionResult yenisertifika(Tblsertifikalarim t)
        {
            repo.TAdd(t);
            return RedirectToAction("Index");
        }
        public ActionResult sertifikasil(int id)
        {
            var sertifika = repo.Find(x => x.Id == id);
            repo.TDelete(sertifika);
            return RedirectToAction("Index");

        }

    }
}
