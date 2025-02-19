using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace CEPWebhooks.Functions
{
    public class WebhookHandler
    {
        private readonly ILogger<WebhookHandler> _logger;

        public WebhookHandler(ILogger<WebhookHandler> logger)
        {
            _logger = logger;
        }

        [Function("ProcessRepoOne")]
        public async Task<IActionResult> ProcessRepoOne([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            _logger.LogInformation($"Request Body: {requestBody}");

            return new OkResult();
        }

        [Function("ProcessRepoTwo")]
        public async Task<IActionResult> ProcessRepoTwo([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            _logger.LogInformation($"Request Body: {requestBody}");

            return new OkResult();
        }
    }
}
