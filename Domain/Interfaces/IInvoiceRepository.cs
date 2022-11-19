using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IInvoiceRepository
    {
        Invoice Upsert(Invoice authorbook);
        void Delete(Invoice authorbook);
        IEnumerable<Invoice> GetInvoices();
    }
}
