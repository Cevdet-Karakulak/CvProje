using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CWProje.Models.Entity;
using CWProje.Repositories;

namespace CWProje.Controllers
{
    public class YetenekController : Controller
    {
        // GET: Yetenek
        GenericRepository<Yeteneklerim> repo=new GenericRepository<Yeteneklerim>();
        public ActionResult Index()
        {
            var yetenekler = repo.List();
            return View(yetenekler);
        }
        [HttpGet]
        public ActionResult YeniYetenek ()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniYetenek(Yeteneklerim p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult YetenekSil(int id)
        {
           var yetenek=repo.Find(x=>x.ID==id);
            repo.Tdelete(yetenek);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekDuzenle(int id) 
        {
            var yetenek=repo.Find(x=>x.ID == id);
            return View(yetenek);
        }
        [HttpPost]
        public ActionResult YetenekDuzenle(Yeteneklerim t)
        {
            var y=repo.Find(x=>x.ID==t.ID);
            y.Yetenek=t.Yetenek;
            y.Oran = t.Oran;
            repo.Tupdate(y);
            return RedirectToAction("Index");
        }
    }
}