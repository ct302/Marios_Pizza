using API.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeCRUD.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerOrderController : GenericController<CustomerOrder>
    {

        public CustomerOrderController(IGenericService<CustomerOrder> genericService) : base(genericService)
        {



        }

    }
}
