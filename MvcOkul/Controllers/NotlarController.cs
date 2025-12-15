using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOkul.Models.EntityFramework;
using MvcOkul.Models;

namespace MvcOkul.Controllers
{
    public class NotlarController : Controller
    {
        // GET: Notlar
        DbMvcOkulEntities2 db=new DbMvcOkulEntities2();
        public ActionResult Index()
        {
            var notlar=db.TBLNOTLAR.ToList();
            return View(notlar);
        }
        [HttpGet]
        public ActionResult YeniNot()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniNot(TBLNOTLAR tbn)
        {
            db.TBLNOTLAR.Add(tbn);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult notgetir(int id)
        {
            var ntgetir=db.TBLNOTLAR.Find(id);
            return View("notgetir",ntgetir);
        }
        [HttpPost]
        public ActionResult notgetir(Class1 model, TBLNOTLAR p, int SINAV1=0, int SINAV2=0, int SINAV3=0, int PROJE=0)
        {
            if(model.islem=="HESAPLA")
            {
                int ortalama = (SINAV1 + SINAV2 + SINAV3 + PROJE) / 4;
                ViewBag.ort = ortalama;
            }
            if(model.islem=="NOTGUNCELLE")
            {
                var snv = db.TBLNOTLAR.Find(p.NOTİD);
                snv.SINAV1 = p.SINAV1;
                snv.SINAV2 = p.SINAV2;
                snv.SINAV3 = p.SINAV3;
                snv.PROJE = p.PROJE;
                snv.ORTALAMA = p.ORTALAMA;
                db.SaveChanges();
                return RedirectToAction("Index","Notlar");
                
            }
            return View();
           
        }
    }
}