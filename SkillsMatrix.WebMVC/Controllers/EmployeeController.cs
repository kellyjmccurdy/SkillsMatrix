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
            var model = new SkillsMatrix.Models.EmployeeListItem[0];
            return View(model);
        }
    }
}