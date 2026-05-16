using Microsoft.AspNetCore.Mvc;
using MvcDB.Models;


namespace MvcDB.viewcomponents
{
    public class HobiListesi : ViewComponent
    {
        DbCvContext db = new DbCvContext();
        public IViewComponentResult Invoke()
        {
            // Fotoğraflarında gördüğüm kadarıyla tablonun adı: Tblegitim
            var degerler = db.Tblhobilerims.ToList();
            return View(degerler);
        }
    }
}