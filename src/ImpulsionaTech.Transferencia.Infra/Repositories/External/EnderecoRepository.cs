using System.Net;
using System.Text.Json;
using ImpulsionaTech.Transferencia.Application.Helpers;
using ImpulsionaTech.Transferencia.Application.Responses;
using ImpulsionaTech.Transferencia.Application.Results;
using ImpulsionaTech.Transferencia.Domain.Interfaces.Externals;
using Microsoft.Extensions.Configuration;

namespace ImpulsionaTech.Transferencia.Infra.Repositories.External
{
  public class EnderecoRepository : IEnderecoRepository
  {
    private readonly HttpClient _client;
    private readonly IConfiguration _configuration;

    public EnderecoRepository(HttpClient client, IConfiguration configuration)
    {
      _client = client;
      _configuration = configuration;
    }

    public async Task<RequestResult> GetCep(string cep)
    {
      HttpRequestMessage request = new HttpRequestMessage();
      request.Method = HttpMethod.Get;
      request.RequestUri = UriHelper.GetViaCepUri(cep);
      try
      {
        using (_client)
        {
          var response = await _client.SendAsync(request);
          if (response.StatusCode != HttpStatusCode.OK)
            return new RequestResult().BadRequest("Erro ao tentar recuperar os dados.");

          var cepText = await response.Content.ReadAsStringAsync();
          var cepDto = JsonSerializer.Deserialize<EnderecoResponse>(cepText);


          return new RequestResult().Ok(cepDto);
        }
      }
      catch (Exception ex)
      {
        return new RequestResult().BadRequest(ex.Message);
      }
    }
  }
}
