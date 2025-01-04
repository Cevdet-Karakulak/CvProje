using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CWProje.Models.Entity;
using CWProje.Repositories;

namespace CWProje.Controllers
{
    public class HobilerController : Controller
    {
        // GET: Hobiler
        GenericRepository<Hobilerim> repo=new GenericRepository<Hobilerim>();
        [HttpGet]
        public ActionResult Index()
        {
            var hobi=repo.List();
            return View(hobi);
        }
        [HttpPost]
        public ActionResult Index(Hobilerim t)
        {  
            var hobi = repo.Find(x => x.ID == t.ID);
            hobi.Aciklama1 = t.Aciklama1;
            hobi.Aciklama2 = t.Aciklama2;
            repo.Tupdate(hobi);
            return RedirectToAction("Index");
        }

    }
}