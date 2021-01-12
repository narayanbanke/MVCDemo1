using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Contollers
{
    public class HomeController : Controller
    {
     private  readonly  IEmployeeRepos _employeeRepos;
        public HomeController(IEmployeeRepos employeeRepos)
        {
         //   employeeRepos = new MockEmployeeRepos();
          _employeeRepos = employeeRepos;
        }

        public ViewResult Index()
        {
            //return _employeeRepos.getEmployee(1).name;

            return View(_employeeRepos.getEmployee(1));
        }
        //public JsonResult Details() 
        //{
        //    Employee model = _employeeRepos.getEmployee(1);
        //    return Json(model);


        //}
        public ViewResult Details()
        {
            Employee model = _employeeRepos.getEmployee(1);
            return View(model);


        }


    }
}
