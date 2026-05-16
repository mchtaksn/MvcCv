using Microsoft.AspNetCore.Mvc;
using MvcDB.Models;


namespace MvcDB.viewcomponents
{
    public class YetenekListesi : ViewComponent
    {
        DbCvContext db = new DbCvContext();
        public IViewComponentResult Invoke()
        {
            // Fotoğraflarında gördüğüm kadarıyla tablonun adı: Tblegitim
            var degerler = db.Tblyeteneklerims.ToList();
            return View(degerler);
        }
    }
}