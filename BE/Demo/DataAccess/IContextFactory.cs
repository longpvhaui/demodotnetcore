using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic; 
using System.Text;

namespace DataAccess
{
    internal interface IContextFactory :IDisposable
    {
        DbContext GetDbContext<TContext>() where TContext : DbContext;
    }
}
