using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CWProje.Models.Entity;
using CWProje.Repositories;


namespace CWProje.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        GenericRepository<iletisim> repo= new GenericRepository<iletisim>();
        public ActionResult Index()
        {
            var mesajlar = repo.List();
            return View(mesajlar);
        }
        public ActionResult MesajSil(int id)
        {
            var mesaj= repo.Find(x => x.ID == id);
            repo.Tdelete(mesaj);
            return RedirectToAction("Index");
        }
    }
}