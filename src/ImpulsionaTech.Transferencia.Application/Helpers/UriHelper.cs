using Microsoft.Extensions.Configuration;

namespace ImpulsionaTech.Transferencia.Application.Helpers
{
  public static class UriHelper
  {
    private const string ConfigExternalUriAPI = "ConnectionStrings:APIEnderecos";

    public static Uri GetAPIContasUri(IConfiguration configuration)
    => new Uri(configuration.GetSection("ConnectionStrings:APIContas").ToString());

    public static Uri GetAPIEnderecoUri(IConfiguration configuration)
    => new Uri(configuration.GetSection(ConfigExternalUriAPI).ToString());

    public static Uri GetViaCepUri(string cep)
    {
      return new Uri($"https://viacep.com.br/ws/{cep}/json/");
    }
  }
}
