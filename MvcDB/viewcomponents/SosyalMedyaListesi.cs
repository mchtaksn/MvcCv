using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MvcDB.Models;

namespace MvcDB.viewcomponents
{
    public class SosyalMedyaListesi:ViewComponent
    {
        DbCvContext db = new DbCvContext();
        public IViewComponentResult Invoke()
        {
            var sosyalmedya = db.Tblsosyalmedyas.ToList();
            return View (sosyalmedya);
        }
    }
}
