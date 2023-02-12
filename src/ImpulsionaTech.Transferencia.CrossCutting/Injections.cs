using ImpulsionaTech.Transferencia.Domain.Interfaces.Caching;
using ImpulsionaTech.Transferencia.Domain.Interfaces.Externals;
using ImpulsionaTech.Transferencia.Infra.Data.Context;
using ImpulsionaTech.Transferencia.Infra.Repositories;
using ImpulsionaTech.Transferencia.Infra.Repositories.Caching;
using ImpulsionaTech.Transferencia.Infra.Repositories.External;
using Microsoft.Extensions.DependencyInjection;

namespace ImpulsionaTech.Transferencia.CrossCutting
{
  public static class Injections
  {
    public static void AddRegisterServicesAplicacao(this IServiceCollection services)
    {
      services.AddScoped<ICachingService, CachingService>();

      services.AddScoped<IConsultaEnderecoRepository, ConsultaEnderecoRepository>();

      services.AddHttpClient<IEnderecoRepository, EnderecoRepository>();

      services.AddScoped<IEnderecoRepository, EnderecoRepository>();

      services.AddScoped<IEnderecoContext, EnderecoContext>();
    }
  }
}
