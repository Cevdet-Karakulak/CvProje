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
    }
   
}