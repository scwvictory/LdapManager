using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

using System.Data.Entity;
using LdapManagerApi.Migrations;
using LdapManagerApi.Models;

namespace LdapManagerApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //マイグレーション
            Database.SetInitializer<LdapManagerDbContext>(
                new LdapManagerDbInitializer());
        }
    }
}
