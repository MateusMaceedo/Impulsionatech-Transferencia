using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace ImpulsionaTech.Transferencia.Api.Middlewares
{
  public class ErrorHandlerMiddleware
  {
    private readonly IWebHostEnvironment _webHostEnvironment;

    public ErrorHandlerMiddleware(IWebHostEnvironment webHostEnvironment)
    {
      _webHostEnvironment = webHostEnvironment;
    }

    public async Task Invoke(HttpContext context)
    {
      var ex = context.Features.Get<IExceptionHandlerFeature>()?.Error;

      if (ex == null)
        return;

      var problemDetails = new ProblemDetails
      {
        Title = ex.InnerException?.Message ?? ex.Message,
        Instance = context.Request.Path
      };

      if (_webHostEnvironment.IsDevelopment())
        problemDetails.Detail = ex.StackTrace;

      await context.Response.WriteAsJsonAsync(problemDetails);
    }
  }
}
