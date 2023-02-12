using Microsoft.Extensions.DependencyInjection;

namespace ImpulsionaTech.Transferencia.Infra.Extensions
{
  public static class RedisExtensions
  {
    public static void InjectRedis(this IServiceCollection services)
    {
      services.AddStackExchangeRedisCache(o =>
      {
        o.InstanceName = "instance";
        o.Configuration = "localhost:6379";
      });
    }
  }
}
