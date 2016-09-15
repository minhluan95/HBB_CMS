using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HBB_CMS.Areas.Admin.Interface
{
    public interface IDbContextFactory
    {
        DbContext GetDbContext();
    }
    public class DbContextFactory<T> : IDbContextFactory where T : DbContext, new()
    {
        private readonly DbContext _context;
        public DbContextFactory()
        {
            _context = new T();
        }
        public DbContext GetDbContext()
        {
            return _context;
        }
    }
}