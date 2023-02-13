using ImpulsionaTech.Transferencia.Api.Middlewares;
using ImpulsionaTech.Transferencia.CrossCutting;
using ImpulsionaTech.Transferencia.Infra.Extensions;

var builder = WebApplication.CreateBuilder(args);

/// <summary>
/// Services Configurations
/// </summary>
builder.Services.AddControllers();

builder.Services.InjectRedis();

builder.Services.AddRegisterServicesAplicacao();

builder.Services.InjectVersioning();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

/// <summary>
/// App Configurations:
/// </summary>

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseExceptionHandler(new ExceptionHandlerOptions
{
  ExceptionHandler = new ErrorHandlerMiddleware(app.Environment).Invoke
});

app.MapControllers();

app.Run();
