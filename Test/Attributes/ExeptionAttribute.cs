using System;
using System.Web;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace DockerDetyr4.Attributes
{
    public class ExeptionAttribute : ActionFilterAttribute, IExceptionFilter
    {

        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled &&
             filterContext.Exception is ArgumentOutOfRangeException)
            {
                filterContext.Result
                = new RedirectResult("~/Home/ErrorPage");
                filterContext.ExceptionHandled = true;
            }
        }
    }
}
