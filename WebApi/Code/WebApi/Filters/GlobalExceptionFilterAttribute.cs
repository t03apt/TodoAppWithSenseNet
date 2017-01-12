using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;
using Newtonsoft.Json;
using SenseNet.Diagnostics;

namespace WebApi.Code.WebApi.Filters
{
    public class GlobalExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            Logger.WriteException(context.Exception);

            var jsonSerializerSettings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

            var response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new StringContent(JsonConvert.SerializeObject(context.Exception, jsonSerializerSettings))
            };

            context.Response = response;
        }
    }
}