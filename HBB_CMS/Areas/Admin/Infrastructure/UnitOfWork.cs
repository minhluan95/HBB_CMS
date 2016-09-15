﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using HBB_CMS.Areas.Admin.Interface;
namespace HBB_CMS.Areas.Admin.Infrastructure
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DbContext _dbContext;
        private bool _disposed;
        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(this._dbContext);
        }
        public UnitOfWork(IDbContextFactory dbContextFactory)
        {
            _dbContext = dbContextFactory.GetDbContext();
        }
        public void Save()
        {
            if (_dbContext.GetValidationErrors().Any())
            {
                throw (new Exception(_dbContext.GetValidationErrors().ToList()[0].ValidationErrors.ToList()[0].ErrorMessage));
            }
            _dbContext.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }
        public void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }

            _disposed = true;

        }
    }
}