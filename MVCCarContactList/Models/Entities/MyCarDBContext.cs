using Microsoft.EntityFrameworkCore;
using MVCCarContactList.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCarContactList.Models.Entities
{
    public partial class CarDBContext
    {

        public CarDBContext(DbContextOptions<CarDBContext> options) : base(options)
        {

        }

        internal void AddCar(CarsCreateVM viewModel)
        {

            Car newCar = new Car()
            {
                Brand = viewModel.Brand,
                Doors = viewModel.Doors,
                TopSpeed = viewModel.TopSpeed,
                //newCar.Id = GetNextID();
            };

            Car.Add(newCar);

            SaveChanges();

        }

        public CarsIndexVM[] ListCars()
        {
            var q = Car
                .Select(c => new CarsIndexVM()
                {
                    Brand = c.Brand,
                    ShowAsFast = c.TopSpeed >= 250,
                    Id = c.Id,
                });

            return q.ToArray();
        }

        public CarsDetailsVM GetDetailsById(int id)
        {
            var car = Car.FirstOrDefault(c => c.Id == id);

            CarsDetailsVM carsDetailsVM = new CarsDetailsVM
            {
                Brand = car.Brand,
                Doors = car.Doors,
                TopSpeed = car.TopSpeed,
            };

            return carsDetailsVM;
        }
    }
}
