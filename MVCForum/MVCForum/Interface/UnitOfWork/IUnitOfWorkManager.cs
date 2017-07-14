using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCForum.WebSite.Interface.UnitOfWork
{
    public partial interface IUnitOfWorkManager : IDisposable
    {
        //IUnitOfWork NewUnitOfWork(bool isReadyOnly);     
        IUnitOfWork NewUnitOfWork();
    }
}