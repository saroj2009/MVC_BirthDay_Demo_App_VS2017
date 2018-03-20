using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GetDay.Models;

namespace GetDay.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();

        }
        // Post: Employee
        [HttpPost]
        [ActionName("Index")]
        public ActionResult IndexPost(Employee emp)
        {
            string strDate = Convert.ToString(emp.DOB);
            string strName = Convert.ToString(emp.EmpName);
            string[] arr1 = strDate.Split(' ');
            strDate = arr1[0];

            return RedirectToAction("Index", "Date", new { date = strDate, name= strName });
           // return View();

        }


    }
}