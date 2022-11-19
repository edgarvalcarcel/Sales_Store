using Application.UnitTets.Common;
using Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Application.Services;
using Application.Interfaces;
using Shouldly;
using Moq;
using Domain.Models;
//using WebUI.Controllers;

namespace Application.UnitTets
{
    /*: CommandTestBase*/
    public class InvoiceServiceUnitTest
    {
        private readonly IInvoiceService _invoiceService;
        public InvoiceServiceUnitTest(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }
    }
}
