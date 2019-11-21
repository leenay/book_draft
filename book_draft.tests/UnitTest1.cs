using book_draft.data.DataAccess;
using book_draft.data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace book_draft.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task CustomersMiddleNameisAAA()
        {
            //arrange
            //ICustomerRepository repo = GetInMemoryProductRepository();
            var options = new DbContextOptionsBuilder<BankContext>().UseInMemoryDatabase("CanSaveCustomers").Options;

            //act
            //run the test against one instance of the context
            using (var context = new BankContext(options))
            {
                var repo = new BankRepo(context);
                await repo.AddCustomerAsync(new Customer { FirstName = "Customer1FN", LastName = "Customer1LN", MiddleName="SomethingElse"});
            }

            //assert
            //run against another instance of the context to verify correct data saved to the db
            //run against the actual db rather than calling tehe repo to retrieve data
            using (var context = new BankContext(options))
            {
                var firstCust = context.Customers.FirstOrDefault();

                Assert.AreEqual("Customer1FN", firstCust.FirstName);
                Assert.AreEqual("Customer1LN", firstCust.LastName);
                Assert.AreEqual("AAA", firstCust.MiddleName);
            }
        }
    }
}
