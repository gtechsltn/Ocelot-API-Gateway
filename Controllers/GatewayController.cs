using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ApiGatewayWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GatewayController : ControllerBase
    {
        [HttpGet]
        public string Get(int id)
        {


            return "Welcome to API Gateway..";
        }

    }
}
