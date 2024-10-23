using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace APIGATEWAYSPG.Handlers
{
    public class CustomHeaderHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomHeaderHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            // Retrieve the custom header
            var customAuthorization = context.Request.Headers["x-api-key"].ToString();

            // Example of modifying or adding headers
            if (!string.IsNullOrEmpty(customAuthorization))
            {
                context.Request.Headers["Authorization"] = customAuthorization; // Map to Authorization
            }


            // Call the next middleware in the pipeline
            await _next(context);
        }
    }
}
