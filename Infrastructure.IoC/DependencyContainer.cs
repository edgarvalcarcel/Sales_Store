using Application.Interfaces;
using Application.Services;
using Domain.Interfaces;
using Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Connecting interfaces from Application layer | Domain.Interfaces | Infrastructure.Data.Repositories 
            // and implementations from others projects in this layer as a point of reference

            //Application layer
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICustomerService, CustomerService>();

            // Domain.Interfaces | Infrastructure.Data.Repositories
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceDetailsRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceDetailsRepository>();
        }
    }
}
