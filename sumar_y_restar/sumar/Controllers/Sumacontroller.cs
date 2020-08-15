using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace sumar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Sumacontroller : ControllerBase
    {
        [HttpGet]
        [Route("Add")]
        public int Add(int a, int b)
        {
            return a + b;
        }
        [HttpPost]
        [Route("Add")]
        public int Add2([FromHeader]int a, [FromHeader]int b)
        {
            return a + b;
        }
        [HttpGet]
        [Route("Product")]
        public int Product(int a, int b)
        {
            return a * b;
        }
        [HttpPost]
        [Route("Product")]
        public int Product2([FromHeader] int a, [FromHeader] int b)
        {
            return a * b;
        }
    }
}
