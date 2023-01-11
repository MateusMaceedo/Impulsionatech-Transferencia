using Microsoft.Extensions.Configuration;

namespace ImpulsionaTech.Transferencia.Application.Helpers
{
  public static class UriHelper
  {
    public static Uri GetAPIContasUri(IConfiguration? configuration)
    => new Uri(configuration.GetSection("ConnectionStrings:APIContas").ToString());
  }
}
