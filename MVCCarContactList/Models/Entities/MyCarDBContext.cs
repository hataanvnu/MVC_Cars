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
                });

            return q.ToArray();
        }
    }
}
