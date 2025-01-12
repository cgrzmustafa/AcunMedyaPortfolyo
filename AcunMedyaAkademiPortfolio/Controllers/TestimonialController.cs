using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class TestimonialController : Controller
    {
        DbDominicPortfolioEntities db = new DbDominicPortfolioEntities();
        public ActionResult TestimonialList()
        {
            var values = db.TblTestimonial.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTestimonial(TblTestimonial p)
        {
            db.TblTestimonial.Add(p);
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var values = db.TblTestimonial.Find(id);
            db.TblTestimonial.Remove(values);
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}

