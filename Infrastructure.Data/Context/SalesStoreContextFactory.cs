using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Context
{
    public class SalesStoreContextFactory : DesignTimeDbContextFactoryBase<SalesStoreContext>
    {
        protected override SalesStoreContext CreateNewInstance(DbContextOptions<SalesStoreContext> options)
        {
            return new SalesStoreContext(options);
        }
    }
}
