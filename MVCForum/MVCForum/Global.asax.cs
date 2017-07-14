using MVCForum.WebSite.Application;
using MVCForum.WebSite.Interface.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCForum.WebSite
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public IUnitOfWorkManager UnitOfWorkManager
        {
            get { return ServiceFactory.Get<IUnitOfWorkManager>(); }
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
