using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCarContactList.Models.ViewModels
{
    public class CarsDetailsVM
    {
        public string Brand { get; set; }
        public int? Doors { get; set; }
        public int? TopSpeed { get; set; }
    }
}
