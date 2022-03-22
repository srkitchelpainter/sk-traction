using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LearnSc93Proj.Pipelines
{
    //TO-DO: Implement custom route configuration for dependency injection needed for unit testing Feature\Contacts\code\Controllers\CreateContactController.cs
    public class RegisterCustomRoute
    {
        public virtual void Process(PipelineArgs args)
        {
            Register();
        }
        public static void Register()
        {
            RouteTable.Routes.MapRoute("CustomRoute", "some/route/{controller}/{action}/{id}");
        }
    }
}