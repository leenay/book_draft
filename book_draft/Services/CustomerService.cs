using book_draft.data.DataAccess;
using book_draft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_draft.Services
{
    public class CustomerService : ICustomerService
    {
        private IBankRepo _repo;

        public CustomerService(IBankRepo repo)
        {
            _repo = repo;
        }

        public async Task AddCustomerAsync(Customer customer)
        {
            var dataCustomer = new domain.Customer();
            dataCustomer.FirstName = customer.FirstName;
            dataCustomer.MiddleName = customer.MiddleName;
            dataCustomer.LastName = customer.LastName;

            await _repo.AddCustomerAsync(dataCustomer);
        }
    }
}
