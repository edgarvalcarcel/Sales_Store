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
    public class InvoiceDetailsRepository : IInvoiceRepository
    {
        public SalesStoreContext _context;
        public InvoiceDetailsRepository(SalesStoreContext context)
        {
            _context = context;
        }

        public void Delete(InvoiceDetails details)
        {
            
        }

        public IEnumerable<InvoiceDetails> GetInvoiceDetailsByInvoiceId(int Id)
        {
            return _context.InvoiceDetails.Include(a => a.Invoice).Where(i => i.InvoiceID == Id);
        }

        void IInvoiceRepository.Delete(Invoice authorbook)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Invoice> GetInvoices()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Invoice> IInvoiceRepository.GetInvoices()
        {
            throw new NotImplementedException();
        }

        Invoice Upsert(Invoice authorbook)
        {
            throw new NotImplementedException();
        }

        Invoice IInvoiceRepository.Upsert(Invoice authorbook)
        {
            throw new NotImplementedException();
        }
    }
}
