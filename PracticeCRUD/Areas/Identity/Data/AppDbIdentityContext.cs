using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PracticeCRUD.DbData;

namespace PracticeCRUD.Data
{
    public class AppDbIdentityContext : IdentityDbContext<IdentityUser>
    {
        public AppDbIdentityContext(DbContextOptions<AppDbIdentityContext> options)
            : base(options)
        {
        }



        public DbSet <NewData.NewCustomerOrder> newCustomerOrders { get; set; }

        public DbSet<MyCustomer> Customers { get; set; }

        public DbSet<CustomerOrder> CustomerOrder { get; set; }




    }
}
