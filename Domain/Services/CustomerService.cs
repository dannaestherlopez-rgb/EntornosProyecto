using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.DTO;
using Domain.Models.Interfaces;

namespace Domain.Services
{
    public class CustomerService
    {
        private readonly ICustomer _customer;
        public CustomerService(ICustomer customer)
        {
            _customer = customer;
        }
        public async  Task<List<CustomerDto>> GetCustomers()
        {
            return await _customer.GetCustomers();
        }
    }
}
