using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using System.Web.Mvc;
using System.Web.Routing;
using PabxInfo.Models.Models;
using PabxInfo.Models;

namespace PabxInfo
{

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Mapper.Initialize(cfg =>
            {
                //Category
                cfg.CreateMap<DesignationAddViewModel, Designation>();
                cfg.CreateMap<Designation, DesignationAddViewModel>();
            });
        }
    }


}
