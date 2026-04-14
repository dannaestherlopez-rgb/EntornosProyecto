using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.DTO;
using Domain.Models.Interfaces;
using DataAccess.Mappers;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using DataAccess.Models;

namespace DataAccess.Repositories
{
    public class CustomerRepository : ICustomer
    {
        private readonly NorthwindContext _context;

        public CustomerRepository(NorthwindContext context)
        {
            _context = context;
        }

        public async Task<CustomerDto?> GetCustomerById(string CustomerId)
        {
            var customer = await _context.Customers
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.CustomerID == CustomerId);
            return customer is null ? null : CustomerMap.ToDto(customer);
        }

        public async Task<List<CustomerDto>> GetCustomers()
        {
            return await _context.Customers
                .AsNoTracking()
                .Select(p => CustomerMap.ToDto(p))
                .ToListAsync();
        }

        public async Task<CustomerDto?> InsertCustomer(CustomerDto customer)
        {
            Customer customerToInsert = CustomerMap.ToEntity(customer);
            _context.Customers.Add(customerToInsert);

            return await _context.SaveChangesAsync() > 0 ? CustomerMap.ToDto(customerToInsert) : null;  
        }
    }
}
