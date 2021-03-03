using API.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeCRUD.DbData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : GenericController<MyCustomer>
    {

        public CustomerController(IGenericService<MyCustomer> genericService) : base(genericService)
        {



        }


    }
}
