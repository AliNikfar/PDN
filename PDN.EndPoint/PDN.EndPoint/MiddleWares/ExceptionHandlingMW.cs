using PDN.Application.Exception.Validation;
using System.Text.Json;

namespace PDN.EndPoint.MiddleWares
{
    internal sealed class ExceptionHandlingMW : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (ValidationException e)
            {
                await HandleValidationException(context, e);
            }
        }
        private static async Task HandleValidationException(HttpContext httpContext, ValidationException validationException)
        {
            var statusCode = GetStatusCode(validationException);

            var response = new
            {
                status = GetStatusCode(validationException),
                errors = GetErrors(validationException)
            };
            httpContext.Response.ContentType = "application/json";

            await httpContext.Response.WriteAsync(JsonSerializer.Serialize(response));
        }

        private static int GetStatusCode(Exception exception) =>
            exception switch
            {
                ValidationException => StatusCodes.Status406NotAcceptable,
                _ => StatusCodes.Status500InternalServerError
            };

        private static IReadOnlyDictionary<string, string[]> GetErrors(Exception exception)
        {
            IReadOnlyDictionary<string, string[]> errors = null;

            if (exception is ValidationException validationException)
            {
                errors = validationException.ErrorsDictionary;
            }
            return errors;
        }
    }
}
