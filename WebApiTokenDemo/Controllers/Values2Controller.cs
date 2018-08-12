using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiTokenDemo.Controllers
{
    [ApiVersion("2.0")]
    [ApiVersion("3.0")]
    // [Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/v{version:apiVersion}/Values")]
    [ApiController]
    public class Values2Controller : ControllerBase
    {
        // GET: api/Values2
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var myApiVersion = HttpContext.GetRequestedApiVersion();
            return new string[] { "from v2", "value1", "value2", $"ApiVersion {myApiVersion}" };
        }

        [HttpGet, MapToApiVersion("3.0")]
        public IEnumerable<string> GetV3()
        {
            var myApiVersion = HttpContext.GetRequestedApiVersion();
            return new string[] { "from v3", "value1", "value2", $"ApiVersion {myApiVersion}" };
        }


    }
}
