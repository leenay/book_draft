using book_draft.domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace book_draft.data.DataAccess
{
    public interface IBankRepo
    {
        Task AddCustomerAsync(Customer customer);
    }
}
