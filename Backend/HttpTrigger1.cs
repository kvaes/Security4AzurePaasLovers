using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Security4PaasLovers.Function
{
    public class HttpTrigger1
    {
        private readonly ILogger<HttpTrigger1> _logger;

        public HttpTrigger1(ILogger<HttpTrigger1> logger)
        {
            _logger = logger;
        }

        [Function("HttpTrigger1")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            string nosecret = "sp=r&st=2024-08-09T11:28:31Z&se=2024-08-09T19:28:31Z&spr=https&sv=2022-11-02&sr=c&sig=GnCtmi764jnR%2B09eBoEQ%2BRPNI0U5eaORZ9H4qO2QToc%3D";
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
