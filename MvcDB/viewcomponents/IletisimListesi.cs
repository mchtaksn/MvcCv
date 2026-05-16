using Microsoft.AspNetCore.Mvc;
using MvcDB.Models;

namespace MvcDB.viewcomponents
{
    public class IletisimListesi : ViewComponent
    {
        DbCvContext db = new DbCvContext();
        public IViewComponentResult Invoke()
        {

            var degerler = db.Tbliletisims.ToList();
            return View(degerler);
        }
    }
}