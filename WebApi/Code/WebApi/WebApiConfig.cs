using System.Web.Http;
using SenseNet.Portal;

namespace WebApi.Code.WebApi
{

    public class WebApiConfig : WebApiConfiguration
    {
        protected override void Configure(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "TodoAppWebApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.XmlFormatter.UseXmlSerializer = false;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}