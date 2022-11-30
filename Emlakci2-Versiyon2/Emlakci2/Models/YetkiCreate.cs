using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;//action filter attribute icin eklendi

namespace Emlakci2.Models
{
    public class YetkiCreate : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["yetki"] == "0")
            {
                //eger yetki 0 ise anasayfaya donecek
                filterContext.Result = new RedirectResult("~/Home/Index");
            }
            base.OnActionExecuting(filterContext);
        }
    }
}