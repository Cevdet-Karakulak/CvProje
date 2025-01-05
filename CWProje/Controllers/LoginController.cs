using CWProje.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CWProje.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            CwProjeEntities db=new CwProjeEntities();
            var bilgi = db.Admin.FirstOrDefault(x => x.KullaniciAdi == p.KullaniciAdi && x.Parola == p.Parola);
            if (bilgi != null)
            {
                FormsAuthentication.SetAuthCookie(bilgi.KullaniciAdi, false);
                Session["KullaniciAdi"]=bilgi.KullaniciAdi.ToString();
                return RedirectToAction("Index","Deneyim");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }            
        }
        public ActionResult LogOut() 
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index","Login"); 
        } 
    }
}