using API.IService;
using Microsoft.AspNetCore.Components;
using PracticeCRUD.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class CustomerOrderService : IGenericService<CustomerOrder>
    {


        public CustomerOrderService(AppDbIdentityContext _db)
        {
            db = _db;

        }


        [Inject]
        public AppDbIdentityContext db { get; set; }


        public List<CustomerOrder> Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerOrder> GetAll()
        {

            return db.CustomerOrder.ToList();

        }

        public CustomerOrder GetById(string Id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerOrder> Insert(CustomerOrder item)
        {
            throw new NotImplementedException();
        }
    }
}
