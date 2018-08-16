using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTokenDemo.Data;

namespace WebApiTokenDemo.Areas.Letting.Controllers
{
    [ApiVersion("1.0")]
    [Area("Letting")]
    //[Route("api/[area]/[controller]")]
    [Route("api/v{version:apiVersion}/[area]/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ApplicationDbContext dbContext;

        public ValuesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        // GET: api/Values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            // return dbContext.Users.Select(u => u.UserName).ToArray();
            return new string[] { "from Area-letting", "value1", "value2" };
        }

        // GET: api/Values/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
