﻿using System;
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
        [HttpGet]
        public ActionResult Ekle() 
        {
            return View(); 
        }
        [HttpPost]
        public ActionResult Ekle(SosyalMedya p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult SayfaGetir(int id)
        {
            var hesap=repo.Find(x=>x.ID==id);
            return View(hesap);
        }
        [HttpPost]
        public ActionResult SayfaGetir(SosyalMedya p)
        {
            var hesap = repo.Find(x => x.ID == p.ID);
            hesap.Ad=p.Ad;
            hesap.Durum=true;
            hesap.Link=p.Link;
            hesap.ikon=p.ikon;
            repo.Tupdate(hesap);
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var hesap=repo.Find(x=> x.ID==id);
            hesap.Durum = false;
            repo.Tupdate(hesap);
            return RedirectToAction("Index");

        }

    }
}