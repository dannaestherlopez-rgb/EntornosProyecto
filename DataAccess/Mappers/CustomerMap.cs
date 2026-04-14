using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.DTO;
using DataAccess.Models;

namespace DataAccess.Mappers
{
    public class CustomerMap
    {
        public static CustomerDto ToDto(Customer customer) { 
            return new CustomerDto
            {
                Id = customer.CustomerID,
                CompanyName = customer.CompanyName,
                ContactName = customer.ContactName ?? "",
                Country = customer.Country ?? ""
            };
        }
        public static Customer ToEntity(CustomerDto customerDto)
        {
            return new Customer
            {
                CustomerID = customerDto.Id,
                Address = customerDto.Address,
                City = customerDto.City,
                CompanyName = customerDto.CompanyName,
                ContactName= customerDto.ContactName,
                ContactTitle = customerDto.ContactTitle,
                Country = customerDto.Country,
                Fax = customerDto.Fax,
                Phone = customerDto.Phone,
                PostalCode = customerDto.PostalCode,
                Region = customerDto.Region,
            };
        }
     }
}
