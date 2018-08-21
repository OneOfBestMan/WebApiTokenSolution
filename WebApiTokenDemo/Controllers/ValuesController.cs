using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApiTokenDemo.Data;

namespace WebApiTokenDemo.Controllers
{
    // [Route("api/[controller]")]
    // [ApiVersionNeutral]
    [ApiVersion("1.0")]
    [ApiVersion("0.9", Deprecated = true)]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ApplicationDbContext dbContext;

        public ValuesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [Authorize]
        [HttpGet("Protected")]
        public ActionResult<IEnumerable<string>> Protected()

        {
            var myApiVersion = HttpContext.GetRequestedApiVersion();
            return new string[] { "from v1 (protected)", "value1", "value2", $"ApiVersion {myApiVersion}" };
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()

        {
            var myApiVersion = HttpContext.GetRequestedApiVersion();
            //return new string[] { "from v1", "value1", "value2", $"ApiVersion {myApiVersion}" };
            //return dbContext.Tenants.Select(r => r.ComputedName).Take(20).ToArray();
            return dbContext.Users.Select(r => r.UserName).Take(20).ToArray();
        }

        // GET api/values/5
        [HttpGet("{id:int}")]
        public ActionResult<string> Get(int id)
        {
            var myApiVersion = HttpContext.GetRequestedApiVersion();
            return $"value is {id}. Api version is {myApiVersion}.";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
