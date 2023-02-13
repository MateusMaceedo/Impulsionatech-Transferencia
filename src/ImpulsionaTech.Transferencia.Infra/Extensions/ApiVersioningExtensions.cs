using Microsoft.Extensions.DependencyInjection;

namespace ImpulsionaTech.Transferencia.Infra.Extensions
{
  public static class ApiVersioningExtensions
  {
    public static void InjectVersioning(this IServiceCollection services)
    {
      services.AddVersionedApiExplorer(options =>
      {
         options.GroupNameFormat = "'v'VVV";
         options.SubstituteApiVersionInUrl = true;
      });

      services.AddApiVersioning(o => o.ReportApiVersions = true);
    }
  }
}
