using CWProje.Models.Entity;
using CWProje.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CWProje.Controllers
{
    public class HakkimdaController : Controller
    {
        GenericRepository<Hakkimda> repo = new GenericRepository<Hakkimda>();
        [HttpGet]
        public ActionResult Index()
        {
            var hakkımda = repo.List();
            return View(hakkımda);
        }
        [HttpPost]
        public ActionResult Index(Hakkimda p)
        {
            var t = repo.Find(x => x.ID == 1);
            t.Ad = p.Ad;
            t.Soyad=p.Soyad ;
            t.Adres= p.Adres;
            t.Telefon=p.Telefon;
            t.Mail=p.Mail;
            t.Açıklama=p.Açıklama;
            t.Resim=p.Resim;            
            repo.Tupdate(t);
            return RedirectToAction("Index");
        }
    }
}