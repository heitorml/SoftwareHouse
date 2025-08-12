using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace SoftwareHouse.CrossCutting.Middleware
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandlingMiddleware> _logger;

        public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                // Log additional details
                _logger.LogError(ex,
                    "Unhandled exception. Path: {Path}, Method: {Method}, TraceIdentifier: {TraceId}",
                    context.Request.Path,
                    context.Request.Method,
                    context.TraceIdentifier);

                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Response.ContentType = "application/json";

                var result = JsonSerializer.Serialize(new
                {
                    error = "An unexpected error occurred.",
                    details = ex.Message // Remove or mask in production
                });

                await context.Response.WriteAsync(result);
            }
        }
    }
}
