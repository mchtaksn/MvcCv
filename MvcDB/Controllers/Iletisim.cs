using Microsoft.AspNetCore.Mvc;
using MvcDB.Models;
using MvcDB.Repositories;

namespace MvcDB.Controllers
{
    public class Iletisim : Controller

    {
        GenericRepositery<Tbliletisim> repo = new GenericRepositery<Tbliletisim>();
        public IActionResult Index()
        {
            var deger = repo.List();
            return View(deger);
        }
    }
}
