using System;
using System.Diagnostics;
using System.Web;
using SenseNet.Portal;

namespace WebApi.Code
{
    public class TodoAppGlobal : SenseNetGlobal
    {
        protected override void Application_BeginRequest(object sender, EventArgs e, HttpApplication application)
        {
            base.Application_BeginRequest(sender, e, application);

            var ctx = HttpContext.Current;
            Trace.WriteLine($"Raw: {ctx.Request.RawUrl}");
            Trace.WriteLine($"X-Original-URL: {ctx.Request.Headers["X-Original-URL"]}");
        }
    }
}

