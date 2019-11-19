using book_draft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_draft.Services
{
    public interface ICustomerService
    {
        Task AddCustomerAsync(Customer customer);
    }
}
