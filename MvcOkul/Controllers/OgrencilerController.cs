using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOkul.Models.EntityFramework;

namespace MvcOkul.Controllers
{
    public class OgrencilerController : Controller
    {
        // GET: Ogrenciler
        DbMvcOkulEntities2 db = new DbMvcOkulEntities2();
        public ActionResult Index()
        {
            var ogrenciler = db.TBLOGRENCİLER.ToList();
            return View(ogrenciler);
        }
        [HttpGet]
        public ActionResult YeniOgrenci()
        {
            List<SelectListItem> degerler = (from i in db.TBLKULUP.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KULUPAD,
                                                 Value = i.KULUPİD.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();

        }
        [HttpPost]
        public ActionResult YeniOgrenci(TBLOGRENCİLER p1)
        {
            var klp=db.TBLKULUP.Where(m=>m.KULUPİD==p1.TBLKULUP.KULUPİD).FirstOrDefault();
            p1.TBLKULUP=klp;
            db.TBLOGRENCİLER.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var ogrenci=db.TBLOGRENCİLER.Find(id);
            db.TBLOGRENCİLER.Remove(ogrenci);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ogrgetir(int id)
        {
            var ogrgtr = db.TBLOGRENCİLER.Find(id);
            return View("ogrgetir", ogrgtr);
        }
        [HttpPost]
        public ActionResult Guncelle(TBLOGRENCİLER p1)
        {
            var ogr = db.TBLOGRENCİLER.Find(p1.OGRENCİİD);
            ogr.OGRAD=p1.OGRAD;
            ogr.OGRSOYADİ = p1.OGRSOYADİ;
            ogr.OGRFOTO = p1.OGRFOTO;
            ogr.OGRCİNSİYET = p1.OGRCİNSİYET;
            ogr.OGRKULUP = p1.OGRKULUP;
            db.SaveChanges();
            return RedirectToAction("Index", "Ogrenciler");

        }
    }
}