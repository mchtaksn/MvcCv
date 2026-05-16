using Microsoft.AspNetCore.Mvc;
using MvcDB.Models;

namespace MvcDB.Controllers
{
    public class Default : Controller
    {
        DbCvContext db = new DbCvContext();
        public IActionResult Index()
        {
            var degerler = db.Tblhakkimizda.ToList();
            return View(degerler);
        }
        public PartialViewResult soyalmedya()
        {
            var sosyalmedya = db.Tblsosyalmedyas.Where(x=>x.Durum==true).ToList();
            return PartialView(sosyalmedya);
        }
        public PartialViewResult deneyim()
        {
            var deneyimler = db.Tbldeneyimlerims.ToList();
            return PartialView(deneyimler);
        }
        public PartialViewResult egitim()
        {
            var egitimler = db.Tblegitims.ToList();
            return PartialView(egitimler);
        }
        public PartialViewResult yetenek()
        {
            var yetenek = db.Tblyeteneklerims.ToList();
            return PartialView(yetenek);
        }
        public PartialViewResult hobiler()
        {
            var hobi = db.Tblhobilerims.ToList();
            return PartialView(hobi);
        }
        public PartialViewResult sertifika()
        {
            var sertifika = db.Tblsertifikalarims.ToList();
            return PartialView(sertifika);
        }
        [HttpGet]
        public PartialViewResult iletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult iletisim(Tbliletisim t)
        {
            db.Tbliletisims.Add(t);
            db.SaveChanges();
            return
                RedirectToAction("Index");

        }
    }
}
