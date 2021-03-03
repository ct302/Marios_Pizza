using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCRUD.Data
{
    public class CustomerOrder
    {

        [Key]
        public string OrderID { get; set; }


        public string UserID { get; set; }
        public string PizzaName { get; set; }
        public string PizzaSize { get; set; }
        public string WingsName { get; set; }
        public string WingsCount { get; set; }
        public string DrinkName { get; set; } = "";
        
        public string DrinkSize { get; set; }
        public int DrinkQuantity { get; set; }

        public Double OrderTotal { get; set; }

        public DateTime OrderTime { get; set; } 

        public string Toppings { get; set; } = "";
        
        [NotMapped]
        public List<string> ToppingsList { get; set; } = new List<string>();

     
            

        
        public double FinalItemPrice { get; set; }


    }
}
