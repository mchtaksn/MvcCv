using Microsoft.AspNetCore.Mvc;
using MvcDB.Models;
using MvcDB.Repositories;

namespace MvcDB.Controllers
{ 
    public class Hakkimda : Controller   
    {
        GenericRepositery<Tblhakkimizdum> repo = new GenericRepositery<Tblhakkimizdum>();
        [HttpGet]
        public IActionResult Index()
        {
            var hakkımda = repo.List();
            return View(hakkımda);
        }
        [HttpPost]
        public IActionResult Index(Tblhakkimizdum p)
        {
            //Tblhobilerim t = new Tblhobilerim ();
            var t = repo.Find(x => x.Id == 1);
            t.Ad = p.Ad;
            t.Soyad = p.Soyad;
            t.Adres = p.Adres;
            t.Telefon = p.Telefon;
            t.Mail = p.Mail;
            t.Aciklama = p.Aciklama;
            t.Resim= p.Resim;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}
