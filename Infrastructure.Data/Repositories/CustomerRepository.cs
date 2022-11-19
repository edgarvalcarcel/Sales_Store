using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public SalesStoreContext _context;
        public CustomerRepository(SalesStoreContext context)
        {
            _context = context;
        }
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers;
        }

        public Customer GetCustomerById(int Id)
        {
            return _context.Customers.FirstOrDefault(a => a.Id == Id);
        }

        Customer Upsert(Customer customer)
        {
            if (customer.Id.HasValue && customer.Id > 0)
            {
                return GetCustomerById(customer.Id.Value);
            }
            else
            {
                Customer entity = new Customer
                {
                    Name = customer.Name,
                    CompanyNumber = customer.CompanyNumber,
                    Address = customer.Address,
                    City = customer.City,
                    Phone1 = customer.Phone1,
                    Phone2 = customer.Phone2,
                    Email = customer.Email,
                    Notes = customer.Notes
                };
                _context.Customers.Add(entity);
                _context.SaveChanges();
                return entity;
            }
        }

        Customer ICustomerRepository.Upsert(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
