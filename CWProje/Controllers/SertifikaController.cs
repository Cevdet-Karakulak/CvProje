using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CWProje.Models.Entity;
using CWProje.Repositories;


namespace CWProje.Controllers
{
    public class SertifikaController : Controller
    {
        // GET: Sertifika
        GenericRepository<Sertifikalarim> repo=new GenericRepository<Sertifikalarim>();
        public ActionResult Index()
        {
            var sertfika=repo.List();
            return View(sertfika);
        }
        [HttpGet]
        public ActionResult SertifikaGetir(int id)
        {
            var sertifika=repo.Find(x=>x.ID==id);
            ViewBag.d = id;
            return View(sertifika);
        }
        [HttpPost]
        public ActionResult SertifikaGetir(Sertifikalarim t)
        {
            var sertifika = repo.Find(x => x.ID == t.ID);
            sertifika.Aciklama=t.Aciklama;
            sertifika.Tarih=t.Tarih;
            repo.Tupdate(sertifika);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YeniSertifika()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSertifika(Sertifikalarim p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");

        }
        public ActionResult SertifikaSil(int id)
        { 
            var sertifika=repo.Find(x=> x.ID==id);
            repo.Tdelete(sertifika);
            return RedirectToAction("Index"); 
        }
    }
}