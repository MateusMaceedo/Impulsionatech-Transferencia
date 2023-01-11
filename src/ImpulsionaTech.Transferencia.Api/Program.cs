using ImpulsionaTech.Transferencia.Api.Middlewares;

var builder = WebApplication.CreateBuilder(args);

/// <summary>
/// Services Configurations
/// </summary>

builder.Services.AddControllers();

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
