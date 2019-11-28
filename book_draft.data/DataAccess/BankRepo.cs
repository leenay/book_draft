using book_draft.domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace book_draft.data.DataAccess
{
    public class BankRepo : IBankRepo
    {
        private BankContext _context;

        //pass in the context via constructor to allow dependancy injection and unit testing of repo
        public BankRepo(BankContext context)
        {
            _context = context;
        }
        public async Task AddCustomerAsync(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
        }
    }
}
