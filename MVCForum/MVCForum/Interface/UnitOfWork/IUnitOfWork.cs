using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCForum.WebSite.Interface.UnitOfWork
{
    public partial interface IUnitOfWork : IDisposable
    {
        void Commit();
        void Rollback();
        void SaveChanges();
        void AutoDetectChangesEnabled(bool option);
        void LazyLoadingEnabled(bool option);
    }
}