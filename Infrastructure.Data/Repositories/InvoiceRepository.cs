using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public class InvoiceRepository : ICustomerRepository
    {
        public SalesStoreContext _context;
        public InvoiceRepository(SalesStoreContext context)
        {
            _context = context;
        }

        public Customer GetCustomerById(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer Upsert(Customer book)
        {
            throw new NotImplementedException();
        }
    }
}
