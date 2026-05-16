using Microsoft.AspNetCore.Mvc;
using MvcDB.Models;
using MvcDB.Repositories;

namespace MvcDB.Controllers
{
    public class Egitim : Controller
    {
        GenericRepositery<Tblegitim> repo = new GenericRepositery<Tblegitim>();
        public IActionResult Index()
        {
            var egitim = repo.List();
            return View(egitim);
        }
        [HttpGet]
        public ActionResult egitimekle()
        {
           return View();
        }
        [HttpPost]
        public ActionResult egitimekle(Tblegitim t)
        {
            repo.TAdd(t);
            return RedirectToAction("Index");
        }
        
        public ActionResult egitimsil(int id)
        {
            Tblegitim t = repo.Find(x =>x.Id == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult egitimdüzenle(int id)
        {
            Tblegitim t = repo.Find(x => x.Id == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult egitimdüzenle(Tblegitim p)
        {
            Tblegitim t = repo.Find(x => x.Id == p.Id);
            t.Baslik = p.Baslik;
            t.Altbaslik1 = p.Altbaslik1;
            t.Altbaslik2 = p.Altbaslik2;
            t.Tarih=p.Tarih;
            t.Gno=p.Gno;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }


    }
}
