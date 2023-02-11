using System.Text.Json.Serialization;

namespace ImpulsionaTech.Transferencia.Application.Requests
{
  public class TransferenciaRequest
  {
    [JsonPropertyName("nome")]
    public string Nome { get; set; }
    [JsonPropertyName("conta_origem")]
    public string ContaOrigem { get; set; }
    [JsonPropertyName("conta_destino")]
    public string ContaDestino { get; set; }
    [JsonPropertyName("agencia_origen")]
    public string AgenciaOrigem { get; set; }
    [JsonPropertyName("agencia_destino")]
    public string AgenciaDestino { get; set; }
    [JsonPropertyName("valor")]
    public decimal Valor { get; set; }
  }
}
