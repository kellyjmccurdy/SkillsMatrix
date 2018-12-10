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

        public ActionResult Edit(int id)
        {
            var service = CreateQualificationService();
            var detail = service.GetQualificationById(id);
            var model =
                new QualificationEdit
                {
                    QualificationId = detail.QualificationId,
                    OwnerId = detail.OwnerId,
                    EmployeeId = detail.EmployeeId,
                    NameOfSkill = detail.NameOfSkill,
                    LevelOfSkill = detail.LevelOfSkill,
                    YrsOfExperience = detail.YrsOfExperience,
                    NameOfCertification = detail.NameOfCertification
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, QualificationEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.QualificationId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateQualificationService();

            if (service.UpdateQualification(model))
            {
                TempData["SaveResult"] = "Your qualifications have been updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your qualifications could not be updated.");
            return View();
        }

        public ActionResult Delete(int id)
        {
            var svc = CreateQualificationService();
            var model = svc.GetQualificationById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost (int id)
        {
            var service = CreateQualificationService();

            service.DeleteQualification(id);

            TempData["SaveResult"] = "Your qualification was deleted.";

            return RedirectToAction("Index");
        }

        private QualificationService CreateQualificationService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new QualificationService(userId);
            return service;
        }
    }
}