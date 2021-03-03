using Microsoft.AspNetCore.Components;
using PracticeCRUD.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCRUD.Code_Behind
{
    public class Topping_Code_Behind : LayoutComponentBase
    {
        public List<PizzaTopping> listOfPizzaToppings;
        public List<string> Meat_Toppings;
        public List<string> Veggie_Toppings;
        public const double Topping_Price_Pineapples = 2.39;

        [Parameter]
        public double FinalPrice { get; set; } 

        public Dictionary<string, double> Topping_Price_Dict;

        protected override void OnInitialized()
        {



        }



    }
}
