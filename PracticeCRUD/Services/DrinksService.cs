using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCRUD.Services
{
    public class DrinksService
    {
        public bool cannedSodaSelected { get; set; }
        public double CannedSoda { get; set; } = 1.99;
        public double Two_Liter { get; set; } = 3.99;

        public string DrinkType { get; set; }
        public int Quantity { get; set; }

        public string DrinkSize { get; set; }
        public string DrinkName { get; set; }

        public double FinalDrinkPrice{ get; set; }



      
    }

      




}
