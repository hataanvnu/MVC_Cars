using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCarContactList.Models;
using MVCCarContactList.Models.Entities;
using MVCCarContactList.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCCarContactList.Controllers
{
    public class CarsController : Controller
    {

        private CarDBContext context;

        public CarsController(CarDBContext context)
        {
            this.context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Title"] = "Welcome";
            return View(context.ListCars());
        }

        [HttpGet]
        public IActionResult Create()
        {
            SetTitleForCreate();
            return View();
        }

        [HttpPost]
        public IActionResult Create(CarsCreateVM carsCreateVM)
        {

            if (!ModelState.IsValid)
            {
                SetTitleForCreate();
                return View(carsCreateVM);
            }

            context.AddCar(carsCreateVM);

            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Inserts the Title for the create page into the ViewData.
        /// </summary>
        [NonAction]
        private void SetTitleForCreate()
        {
            ViewData["Title"] = "Create";
        }

    }
}
