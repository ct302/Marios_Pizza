using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCRUD.Data
{
    public class User : IdentityUser
    {
        public List<User> ListOfUsers { get; set; }
    }
}
