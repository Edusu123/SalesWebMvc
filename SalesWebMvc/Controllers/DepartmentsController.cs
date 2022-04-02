﻿using Microsoft.AspNetCore.Mvc;

using SalesWebMvc.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            var list = new List<Department>()
            {
                new Department{Id = 1, Name = "Electronics"},
                new Department{Id = 2, Name = "Fashion"}
            };

            return View(list);
        }
    }
}