using System.Text.Json.Serialization;

namespace ImpulsionaTech.Transferencia.Application.Responses
{
  public class TransferenciaResponse
  {
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("nome_origem")]
    public string NomeOrigem { get; set; }
    [JsonPropertyName("nome_destino")]
    public string NomeDestino { get; set; }
    [JsonPropertyName("conta_origem")]
    public string ContaOrigem { get; set; }
    [JsonPropertyName("conta_destino")]
    public string ContaDestino { get; set; }
    [JsonPropertyName("agencia_origem")]
    public string AgenciaOrigem { get; set; }
    [JsonPropertyName("agencia_destino")]
    public string AgenciaDestino { get; set; }
    [JsonPropertyName("valor")]
    public decimal Valor { get; set; }
    [JsonPropertyName("data_transferencia")]
    public DateTime DataTransferencia { get; set;}
    [JsonPropertyName("alterado_em")]
    public DateTime? AlteradoEm { get; set; }
  }
}
