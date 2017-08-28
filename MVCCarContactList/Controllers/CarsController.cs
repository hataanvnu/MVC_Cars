using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCarContactList.Models;
using MVCCarContactList.Models.Entities;
using MVCCarContactList.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public IActionResult Details(int id)
        {
            ViewData["Title"] = "Details";
            return View(context.GetDetailsById(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            var carsCreateVM = new CarsCreateVM();

            carsCreateVM.NumDoors = new SelectListItem[]
            {
                new SelectListItem {Text = "3", Value = "3"},
                new SelectListItem {Text = "4", Value = "4"},
                new SelectListItem {Text = "5", Value = "5"},
            };

            SetTitleForCreate();
            return View(carsCreateVM);
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
