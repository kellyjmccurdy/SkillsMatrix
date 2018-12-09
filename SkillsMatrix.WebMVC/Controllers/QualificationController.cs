using Microsoft.AspNet.Identity;
using SkillsMatrix.Models;
using SkillsMatrix.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkillsMatrix.WebMVC.Controllers
{
    [Authorize]
    public class QualificationController : Controller
    {
        // GET: Qualification
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new QualificationService(userId);
            var model = service.GetQualifications();

            return View(model);
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(QualificationCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateQualificationService();

            if (service.CreateQualification(model))
            {
                TempData["SaveResult"] = "Your employee's qualifications were created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Qualifications could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateQualificationService();
            var model = svc.GetQualificationById(id);

            return View(model);
        }

        private QualificationService CreateQualificationService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new QualificationService(userId);
            return service;
        }
    }
}