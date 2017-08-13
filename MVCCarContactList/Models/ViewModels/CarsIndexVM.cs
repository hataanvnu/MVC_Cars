using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCarContactList.Models.ViewModels
{
    /// <summary>
    /// 3.Skapa vy-modellen CarsIndexVM med följande properties:
    ///  - string Brand (ska visas upp för användaren som ”Car Brand” i vyn)
    ///  - bool ShowAsFast (ska vara true om bilens TopSpeed är mer än 250 i vilket fall bilens Brand ska visa upp i blå text i vyn)
    /// </summary>
    public class CarsIndexVM
    {
        [Display(Name = "Car Brand")]
        public string Brand { get; set; }


        public bool ShowAsFast { get; set; }
    }
}
