using System;
using System.Web.Http;

namespace WebApi.Code.WebApi.Controllers
{
    [RoutePrefix("api/hello")]
    public class HelloController : ApiController
    {
        [HttpGet]
        public object Test()
        {
            var assembly = typeof(HelloController).Assembly.GetName();
            return new
            {
                AssemblyName = assembly.Name,
                AssemblyVersion = assembly.Version.ToString(),
                MachineName = Environment.MachineName
            };
        }
    }
}