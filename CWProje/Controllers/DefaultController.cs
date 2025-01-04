using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CWProje.Models.Entity;

namespace CWProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        CwProjeEntities db = new CwProjeEntities();
        public ActionResult Index()
        {
            var degerler = db.Hakkimda.ToList();
            return View(degerler);
        }
        public PartialViewResult SosyalMedya()
        {
            var sosyalmedya = db.SosyalMedya.ToList();
            return PartialView(sosyalmedya);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler=db.Deneyimlerim.ToList();
        return PartialView(deneyimler);
        }

        public PartialViewResult Egitimlerim()
        {
            var egitimler = db.Egitimlerim.ToList();
            return PartialView(egitimler);
        }
        public PartialViewResult Yeteneklerim()
        {
            var yetenekler = db.Yeteneklerim.ToList();
            return PartialView(yetenekler);
        }
        public PartialViewResult Hobilerim()
        {
            var hobiler = db.Hobilerim.ToList();
            return PartialView(hobiler);
        }
        public PartialViewResult Sertifikalarim()
        {
            var sertifika = db.Sertifikalarim.ToList();
            return PartialView(sertifika);
        }
        [HttpGet]
        public PartialViewResult iletisim()
        {
           return PartialView();
        }
        [HttpPost]
        public PartialViewResult iletisim(iletisim t)
        {
            t.Tarih=DateTime.Parse(DateTime.Now.ToShortDateString());
            db.iletisim.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}