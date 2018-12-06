﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkillsMatrix.WebMVC.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            var model = new SkillsMatrix.Models.ProfileListItem[0];
            return View(model);
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SkillsMatrix.Models.ProfileCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}