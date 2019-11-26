using book_draft.domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace book_draft.data
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
