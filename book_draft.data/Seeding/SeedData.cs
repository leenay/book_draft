using book_draft.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace book_draft.data.Seeding
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BankContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BankContext>>()))
            {
                // Look for any movies.
                if (context.Customers.Any())
                {
                    return;   // DB has been seeded
                }

                context.Customers.AddRange(
                    new Customer
                    {
                        FirstName = "FirstName1",
                        MiddleName = "MiddleName1",
                        LastName = "LastName1"
                    },

                    new Customer
                    {
                        FirstName = "FirstName2",
                        MiddleName = "MiddleName2",
                        LastName = "LastName2"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
