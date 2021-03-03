using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCRUD.NewData
{
    public class NewCustomerOrder
    {
        [Key]
        public string OrderID { get; set; }
        public string UserID { get; set; }
        public string Item_Name { get; set; }
        public int Item_Quantity { get; set; }
        public string Item_Price { get; set; }
        public double orderPriceTotal { get; set; }
        public DateTime timeOrdered { get; set; } = DateTime.UtcNow;

    }
}
