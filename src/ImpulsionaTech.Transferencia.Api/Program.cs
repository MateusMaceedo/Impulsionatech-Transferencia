using ImpulsionaTech.Transferencia.Api.Middlewares;
using ImpulsionaTech.Transferencia.Application.UseCases.Commands;
using ImpulsionaTech.Transferencia.Application.UseCases.Handlers;
using ImpulsionaTech.Transferencia.Domain.Interfaces.Caching;
using ImpulsionaTech.Transferencia.Domain.Interfaces.Externals;
using ImpulsionaTech.Transferencia.Infra.Data.Context;
using ImpulsionaTech.Transferencia.Infra.Repositories;
using ImpulsionaTech.Transferencia.Infra.Repositories.Caching;
using ImpulsionaTech.Transferencia.Infra.Repositories.External;

var builder = WebApplication.CreateBuilder(args);

/// <summary>
/// Services Configurations
/// </summary>
builder.Services.AddControllers();

builder.Services.AddStackExchangeRedisCache(o =>
      {
        o.InstanceName = "instance";
        o.Configuration = "localhost:6379";
      });

builder.Services.AddScoped<ICachingService, CachingService>();

builder.Services.AddScoped<ProcessarEnderecoHandler>();

builder.Services.AddScoped<IHandler<ProcessarEnderecoCommand>, ProcessarEnderecoHandler>();

builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();

builder.Services.AddHttpClient<IEnderecoRepository, EnderecoRepository>();

builder.Services.AddScoped<IEnderecoContext, EnderecoContext>();

builder.Services.AddScoped<IConsultaEnderecoRepository, ConsultaEnderecoRepository>();

builder.Services.AddVersionedApiExplorer(options =>
{
  options.GroupNameFormat = "'v'VVV";
  options.SubstituteApiVersionInUrl = true;
});

builder.Services.AddApiVersioning(o => o.ReportApiVersions = true);

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
