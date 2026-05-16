using Microsoft.AspNetCore.Mvc;
using MvcDB.Models;


namespace MvcDB.viewcomponents
{
    public class DeneyimListesi : ViewComponent
    {
        DbCvContext db = new DbCvContext();
        public IViewComponentResult Invoke()
        {
            var degerler = db.Tbldeneyimlerims.ToList();
            return View(degerler);
        }
    }
}