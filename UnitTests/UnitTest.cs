using DataAccess.Context;
using DataAccess.Models;
using DataAccess.Repositories;
using Domain.Models.DTO;
using Domain.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace UnitTests
{
    public class UnitTest
    {
        [Fact]
        public async Task Test1()
        {
            var options = new DbContextOptionsBuilder<NorthwindContext>()
           .Options;

            await using (var context = new NorthwindContext(options))
            {
                var repository = new CustomerRepository(context);

                var result = await repository.GetCustomers();

                Assert.NotNull(result);
            }
        }
        [Fact]
        public async Task Test2()
        {
            var options = new DbContextOptionsBuilder<NorthwindContext>()
           .Options;

            await using (var context = new NorthwindContext(options))
            {
                ICustomer repository = new CustomerRepository(context);

                var result = await repository.GetCustomerById("ALFKI");

                Assert.NotNull(result);
            }
        }
        [Fact]
        public async Task Test3()
        {
            var options = new DbContextOptionsBuilder<NorthwindContext>()
           .Options;

            await using (var context = new NorthwindContext(options))
            {
                ICustomer repository = new CustomerRepository(context);
                CustomerDto newCustomer = new CustomerDto
                {
                    Id = "TEST1",
                    CompanyName = "Test Company",
                    ContactName = "John Doe",
                    ContactTitle = "Manager",
                    Address = "123 Test St",
                    City = "Testville",
                    Region = "Test State",
                    PostalCode = "12345",
                    Country = "Test Country",
                    Phone = "123-456-7890",
                    Fax = "123-456-7891"
                };

                var result = await repository.InsertCustomer(newCustomer);

                Assert.NotNull(result);
            }
        }
    }
}
