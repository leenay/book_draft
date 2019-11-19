using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using book_draft.Models;
using book_draft.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace book_draft.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/Customer
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return new List<Customer> {
                new Customer { Id = 1, FirstName = "FirstName1", MiddleName = "MidName1", LastName="LastName1"},
                new Customer { Id = 2, FirstName = "FirstName2", MiddleName = "MidName2", LastName="LastName2"},
            };
        }

        // GET: api/Customer/5
        [HttpGet("{id}", Name = "Get")]
        public Customer Get(int id)
        {
            return new Customer { Id = id, FirstName = "FirstGetName", LastName = "LastGetName", MiddleName = "MidGetName" };
        }

        // POST: api/Customer
        [HttpPost]
        public async Task<ActionResult<Customer>> PostAsync(Customer customer)
        {
            await _customerService.AddCustomerAsync(customer);

            return Ok("Customer created successfully");
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
