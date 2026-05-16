using Microsoft.AspNetCore.Mvc;
using MvcDB.Models;

namespace MvcDB.viewcomponents
{
    public class SertifikaListesi : ViewComponent
    {
        DbCvContext db = new DbCvContext();
        public IViewComponentResult Invoke()
        {
            // Fotoğraflarında gördüğüm kadarıyla tablonun adı: Tblegitim
            var degerler = db.Tblsertifikalarims.ToList();
            return View(degerler);
        }
    }
}