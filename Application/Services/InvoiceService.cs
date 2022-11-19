using Application.Interfaces;
//using Application.ViewModels;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Services
{
    public class InvoiceService : IUserService
    {
        public ICustomerRepository _bookRepository;
        public IInvoiceRepository _authorbookRepository;
        public InvoiceService(ICustomerRepository bookRepository, IInvoiceRepository authorbookRepository)
        {
            _bookRepository = bookRepository;
            _authorbookRepository = authorbookRepository;
        } 
    }
}
