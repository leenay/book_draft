using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using book_draft.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace book_draft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/Customer
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public Customer Get(int id)
        {
            return new Customer { Id = id, FirstName = "Luke", LastName = "Naylor", MiddleName = "Lee" };
        }

        // POST: api/Customer
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Customer/5
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
