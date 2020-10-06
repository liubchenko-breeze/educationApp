using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace EducationApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var error = Server.GetLastError();
            var code = (error is HttpException) ? (error as HttpException).GetHttpCode() : 500;

            if (code == 500)
            {
                Response.Redirect($"~/Errors/Http500?url={Request.Url}");
            }
            else if (code == 404)
            {
                Response.Redirect("~/Errors/Http404");
            }
            else
            {
                Response.Redirect($"~/Errors/Error");
            }

            //LogError(error);

            //Response.TrySkipIisCustomErrors = true;

            //if (!Environment.IsDevelopment)
            //{
            //    Response.Clear();
            //    Server.ClearError();
            //    if (code == 500)
            //    {
            //        Response.Redirect($"~/Errors/Http500?url={Request.Url}");
            //    }
            //    else if (code == 404)
            //    {
            //        Response.Redirect("~/Errors/Http404");
            //    }
            //    else
            //    {
            //        Response.Redirect($"~/Errors/HttpError?statusCode={code}");
            //    }
            //}
        }
    }
}
