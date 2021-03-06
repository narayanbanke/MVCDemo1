﻿using EntityFrameworkCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _dbContext;

        public HomeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ViewResult Index()
        {
            var _emplst = _dbContext.tblEmployees.Select(e =>
                            new tblEmployees
                            {
                                EmployeeID = e.EmployeeID,
                                EmployeeName = e.EmployeeName,
                                PhoneNumber = e.PhoneNumber,
                                YearsExperience = e.YearsExperience
                            }).ToList();

            
        
            IList<tblEmployees > emplst = _emplst;

            return View(emplst);

        }
    }
}
