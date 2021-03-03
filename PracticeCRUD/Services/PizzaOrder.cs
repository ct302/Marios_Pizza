using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCRUD.Services
{
    public class PizzaOrder
    {


        public string CurrentUserID { get; set; } 
        public string CurrentUserEmail { get; set; }
        public bool isUserGuest { get; set; }
        public bool isUserRegistered { get; set; } = false;


        public string IdentityUserID { get; set; }
    }
}
