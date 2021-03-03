using API.IService;
using Microsoft.AspNetCore.Components;
using PracticeCRUD.Data;
using PracticeCRUD.DbData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class CustomerService : IGenericService<MyCustomer>
    {

        [Inject]
        public AppDbIdentityContext db { get; set; }


        public CustomerService(AppDbIdentityContext _db)
        {
            db = _db;

        }

        public List<MyCustomer> Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public List<MyCustomer> GetAll()
        {

            return db.Customers.ToList();

        }

        public MyCustomer GetById(string Id)
        {
            throw new NotImplementedException();
        }

        public List<MyCustomer> Insert(MyCustomer item)
        {
            throw new NotImplementedException();
        }
    }
}
