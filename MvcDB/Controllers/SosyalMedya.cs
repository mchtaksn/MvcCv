using Microsoft.AspNetCore.Mvc;
using MvcDB.Models;
using MvcDB.Repositories;

namespace MvcDB.Controllers
{
    public class SosyalMedya : Controller
    {
        GenericRepositery<Tblsosyalmedya> repo = new GenericRepositery<Tblsosyalmedya>();
        public IActionResult Index()
        {
            var veriler = repo.List();
            return View(veriler);
        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Tblsosyalmedya p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult sil(int id)
        {
            var deger = repo.Find(x=>x.Id == id);
            deger.Durum = false;
            repo.TUpdate(deger);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult guncelle(int id)
        {
            var deger = repo.Find(x=>x.Id== id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult guncelle(Tblsosyalmedya p)
        {
            var t = repo.Find(x=>x.Id==p.Id);
            t.Durum = true;
            t.Ad = p.Ad;
            t.Link = p.Link;
            t.Ikon = p.Ikon;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}
