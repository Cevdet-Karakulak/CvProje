using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CWProje.Models.Entity;
using CWProje.Repositories;
namespace CWProje.Controllers
{
    public class SosyalMedyaController : Controller
    {
        // GET: SosyalMedya
       GenericRepository<SosyalMedya> repo=new GenericRepository<SosyalMedya>();
       
        public ActionResult Index()
        {
            var veriler=repo.List();
            return View(veriler);
        }
    }
}