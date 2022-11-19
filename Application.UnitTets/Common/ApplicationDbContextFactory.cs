using Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Moq;
using IdentityServer4.EntityFramework.Options;
using Application.Common;
using Domain.Models;

namespace Application.UnitTets.Common
{
    public static class ApplicationDbContextFactory
    {
        public static SalesStoreContext Create()
        {
            var options = new DbContextOptionsBuilder<SalesStoreContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new SalesStoreContext(options);

            context.Database.EnsureCreated();

            //SeedSampleData(context);

            return context;
        }


        public static void Destroy(SalesStoreContext context)
        {
            context.Database.EnsureDeleted();

            context.Dispose();
        }
    }
}
