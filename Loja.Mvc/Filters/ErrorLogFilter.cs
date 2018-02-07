using System.Web.Mvc;

namespace Loja.Mvc.Filters
{
    public class ErrorLogFilter : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            if (filterContext != null && filterContext.Exception != null) //Para evitar erro looping
            {

                var controller = filterContext.RouteData.Values["controller"].ToString();
                var action = filterContext.RouteData.Values["action"].ToString();

                var loggerName = $"{controller}Controler.{action}";

                log4net.LogManager.GetLogger(loggerName).Error(filterContext.Exception.Message, filterContext.Exception);

                base.OnException(filterContext); 
            }
        }
    }
}