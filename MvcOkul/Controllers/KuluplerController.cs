using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOkul.Models.EntityFramework;

namespace MvcOkul.Controllers
{
    public class KuluplerController : Controller
    {
        // GET: Kulupler
        DbMvcOkulEntities2 db = new DbMvcOkulEntities2();
        public ActionResult Index()
        {
            var kulupler = db.TBLKULUP.ToList();
            return View(kulupler);
        }
        [HttpGet]
        public ActionResult YeniKulup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniKulup(TBLKULUP p1)
        {
            db.TBLKULUP.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var kulup=db.TBLKULUP.Find(id);
            db.TBLKULUP.Remove(kulup);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Getirkulup(int id)
        {
            var gtr=db.TBLKULUP.Find(id);
            return View("Getirkulup",gtr);
        }
        public ActionResult Guncelle(TBLKULUP p)
        {
            var klp = db.TBLKULUP.Find(p.KULUPİD);
            klp.KULUPAD=p.KULUPAD;
            db.SaveChanges();
            return RedirectToAction("Index", "Kulupler");
        }
    }
}