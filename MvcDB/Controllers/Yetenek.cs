using Microsoft.AspNetCore.Mvc;
using MvcDB.Models;
using MvcDB.Repositories;
namespace MvcDB.Controllers
{
    public class Yetenek : Controller
    {
        GenericRepositery<Tblyeteneklerim> repo = new GenericRepositery<Tblyeteneklerim>();
        public IActionResult Index()
        {
            var yetenek = repo.List();
            return View(yetenek);
        }
        [HttpGet]
        public ActionResult yetenekekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult yetenekekle(Tblyeteneklerim p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult yeteneksil(int id)
        {
            var yetenek =repo.Find(x=>x.Id == id);
            repo.TDelete(yetenek);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult yetenekguncelle(int id)
        {
            var yetenek = repo.Find(x => x.Id == id);
            return View(yetenek);
        }
        [HttpPost]
        public ActionResult yetenekguncelle(Tblyeteneklerim p)
        {
            Tblyeteneklerim t = repo.Find(x => x.Id == p.Id);
            t.Yetenek = p.Yetenek;
            t.Oran = p.Oran;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}
