using book_draft.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace book_draft.services
{
    interface ICustomerService
    {
        Task AddCustomer(Customer customer);
    }
}
