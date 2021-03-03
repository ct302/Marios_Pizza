using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeCRUD.Code_Behind;
using System.ComponentModel.DataAnnotations;
using PracticeCRUD.Data;

namespace PracticeCRUD.Services
{
    public class PizzaService : ComponentBase
    {

        public string Pizza_Name { get; set; }
        public string Pizza_Size { get; set; }
        public string Wings_Name { get; set; }
        public string Wings_Count { get; set; }

        public DateTime OrderTime { get; set; } = DateTime.UtcNow;

        public CustomerOrder CurrentOrder { get; set; }

        public List<CustomerOrder> TotalOrderItems { get; set; } = new List<CustomerOrder>();

        public Double TotalOrderPrice { get; set; } 
        
        public int ItemCount { get; set; }
        
            
       

        public Guid OrderID { get; set; }
        public Dictionary<string, double> CustomerCartOrder { get; set; } = new Dictionary<string, double>();
        public Dictionary<string, List<string>> Order_Dict { get; set; } = new Dictionary<string, List<string>>();
        
        public List<string> ExtraToppings { get; set; } = new List<string>();
        public double SmallPizzaPrice { get; set; } = 7.99;
        public double MediumPizzaPrice { get; set; } = 11.99;
        public double LargePizzaPrice { get; set; } = 16.99;
        public double XtraLargePizzaPrice { get; set; } = 21.99;

        [Parameter]
        public double FinalPizzaPrice { get; set; }

        public string DrinkName { get; set; }
        public string DrinkSize { get; set; }

        public string DrinkType { get; set; }

        public double finalDrinkPrice { get; set; }



    }
}
