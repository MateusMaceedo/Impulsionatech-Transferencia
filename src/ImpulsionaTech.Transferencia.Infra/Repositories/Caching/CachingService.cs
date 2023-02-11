using ImpulsionaTech.Transferencia.Domain.Interfaces.Caching;
using Microsoft.Extensions.Caching.Distributed;

namespace ImpulsionaTech.Transferencia.Infra.Repositories.Caching
{
  public class CachingService : ICachingService
  {
    private readonly IDistributedCache _cache;
    private readonly DistributedCacheEntryOptions _options;
    public CachingService(IDistributedCache cache)
    {
      _cache = cache;
      _options = new DistributedCacheEntryOptions
      {
        AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(3600),
        SlidingExpiration = TimeSpan.FromSeconds(1200)
      };
    }

    public async Task<string> GetAsync(string key)
    {
      try
      {
        return await _cache.GetStringAsync(key);
      }
      catch (Exception)
      {
        throw new Exception($"Erro ao consultar '{key}', no cache");
      }
    }

    public async Task SetAsync(string key, string value)
    {
      try
      {
         await _cache.SetStringAsync(key, value, _options);
      }
      catch (Exception)
      {
        throw new Exception($"Erro ao inserir '{value}' no cache");
      }
    }
  }
}
