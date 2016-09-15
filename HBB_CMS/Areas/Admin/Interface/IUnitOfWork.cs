using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HBB_CMS.Areas.Admin.Interface
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : class;
        void Save();
    }
}