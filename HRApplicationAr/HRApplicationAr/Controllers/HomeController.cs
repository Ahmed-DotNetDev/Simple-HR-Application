using HRApplicationAr.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HRApplicationAr.Controllers
{
	public class HomeController : Controller
	{

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}
		[HttpGet]
		public ViewResult Employee()
		{
			return View();
		}
		[HttpPost]
		public ViewResult Employee(Employee employee)
		{
			if (ModelState.IsValid)
			{
				Repository.addEMP(employee);

				return View("Confirmation", employee);
			}
			else
				return View();
		}

		public ViewResult DisplayEmployees()
		{

			//Filteration negative status 
			return View(Repository.GetEmployees().Where(emp => emp.isActive == true)); ;
		}


	}
}
