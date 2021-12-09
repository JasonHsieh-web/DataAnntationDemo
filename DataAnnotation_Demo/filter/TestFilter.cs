using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataAnnotation_Demo.filter
{
    public class TestFilter : ActionFilterAttribute
    {

        //public override void OnActionExecuted(ActionExecutedContext filterContext)
        //{
        //    filterContext.Controller.ViewBag.Name="abc";
        //}
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.Name = "abc";
        }
    }
}