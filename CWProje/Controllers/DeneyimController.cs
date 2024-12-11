using CWProje.Models.Entity;
using CWProje.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CWProje.Controllers
{
    public class DeneyimController : Controller
    {
        // GET: Deneyim
        DeneyimRepository repo = new DeneyimRepository();
        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult DeneyimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeneyimEkle(Deneyimlerim p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeneyimSil(int id)
        {
           Deneyimlerim t=repo.Find(x=>x.ID==id);
            repo.Tdelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeneyimGetir(int id)
        {
            Deneyimlerim t=repo.Find(x=> x.ID==id);
            return View(t);
        }
        [HttpPost]
        public ActionResult DeneyimGetir(Deneyimlerim p)
        {
            Deneyimlerim t = repo.Find(x => x.ID == p.ID);
            t.Baslik=p.Baslik;
            t.AltBaslik=p.AltBaslik;
            t.Tarih=p.Tarih;
            t.Aciklama=p.Aciklama;
            repo.Tupdate(t);
            return RedirectToAction("Index"); 
        }
    }
   
}