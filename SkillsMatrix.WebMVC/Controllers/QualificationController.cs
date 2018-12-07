using SkillsMatrix.Models;
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
            var model = new QualificationListItem[0];
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
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}