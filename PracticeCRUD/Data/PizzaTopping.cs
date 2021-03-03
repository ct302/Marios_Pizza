using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCRUD.Data
{
    public class PizzaTopping 
    {

      
        public string Name { get; set; }
        public double Price { get; set; }

        public List<string> Meat_Toppings { get; set; } = new List<string>() { "Pepperoni", "Sausage", "Bacon", "Hamburger", "Grilled Chicken" };
        public List<string> Veggie_Toppings { get; set; } = new List<string>() { "Onions", "Green Peppers", "Tomatos", "Mushrooms", "Pineapples" };

        public Dictionary<string, int> Topping_Price_Dict { get; set; }


     


    }


}
