using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationJqueryDataTable.Models;

namespace WebApplicationJqueryDataTable.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
  
        public ActionResult Index()
        {
            var data = db.employees.ToList();
            return View(data);
        }
	}
}