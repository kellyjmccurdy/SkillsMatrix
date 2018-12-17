using Microsoft.AspNet.Identity;
using SkillsMatrix.Models;
using SkillsMatrix.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ApplicationServices;
using System.Web.Mvc;

namespace SkillsMatrix.WebMVC.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ProfileServices(userId);
            var model = service.GetProfiles();

            return View(model);
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProfileCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateProfileService();

            if (service.CreateProfile(model))
            {
                TempData["SaveResult"] = "Your profile was created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Profile could not be created.");
            return View(model);
        }

        public ActionResult Details (int id)
        {
            var svc = CreateProfileService();
            var model = svc.GetProfileById(id);

            return View(model);
        }

        public  ActionResult Edit(int id)
        {
            var service = CreateProfileService();
            var detail = service.GetProfileById(id);
            var model =
                new ProfileEdit
                {
                    ProfileId = detail.ProfileId,
                    EmployeeId = detail.EmployeeId,
                    QualificationId = detail.QualificationId
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProfileEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if(model.ProfileId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateProfileService();

            if (service.UpdateProfile(model))
            {
                TempData["SaveResult"] = "Your profile has been updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your profile could not be updated.");
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var svc = CreateProfileService();
            var model = svc.GetProfileById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateProfileService();

            service.DeleteProfile(id);

            TempData["SaveResult"] = "Your profile was deleted.";

            return RedirectToAction("Index");
        }

        private ProfileServices CreateProfileService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new ProfileServices(userId);
            return service;
        }
    }
}