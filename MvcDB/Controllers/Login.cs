using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using MvcDB.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace MvcDB.Controllers
{
    public class Login : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Index(Tbladmin p)
        {
            DbCvContext db = new DbCvContext();
            var kullanici = db.Tbladmins.FirstOrDefault(x=>x.Kullaniciadi == p.Kullaniciadi && x.Sifre == p.Sifre);
            if (kullanici != null)
            {
                var claims = new List<Claim>
               {
                   new Claim(ClaimTypes.Name,kullanici.Kullaniciadi)
               };
                var claimIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimIdentity));
                return RedirectToAction("Index","Hakkimda");
            }
            ViewBag.HataMesaji = "Kullanıcı Adı veya Şifre Yanlış";
               return View("Index");
        }
        public async Task<ActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index","Login");
        }
    }
}
