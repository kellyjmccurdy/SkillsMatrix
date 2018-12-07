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
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new EmployeeService(userId);
            var model = service.GetEmployees();

            return View(model);
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateEmployeeService();

            if (service.CreateEmployee(model))
            {
                TempData["SaveResult"] = "Your employee was created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Employee could not be created.");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateEmployeeService();
            var model = svc.GetEmployeeById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateEmployeeService();
            var detail = service.GetEmployeeById(id);
            var model =
                new EmployeeEdit
                {
                    EmployeeId = detail.EmployeeId,
                    FirstName = detail.FirstName,
                    LastName = detail.LastName,
                    JobTitle = detail.JobTitle,
                    LevelOfEducation = detail.LevelOfEducation
                };
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EmployeeEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.EmployeeId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateEmployeeService();

                if (service.UpdateEmployee(model))
                {
                    TempData["SaveResult"] = "Your employee was updated.";
                    return RedirectToAction("Index");
                }

                ModelState.AddModelError("", "Your employee could not be updated.");
                return View(model);
        }

        public ActionResult Delete(int id)
        {
            var svc = CreateEmployeeService();
            var model = svc.GetEmployeeById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateEmployeeService();

            service.DeleteEmployee(id);

            TempData["SaveResult"] = "Your employee was deleted";

            return RedirectToAction("Index");
        }

        private EmployeeService CreateEmployeeService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new EmployeeService(userId);
            return service;
        }
    }
}