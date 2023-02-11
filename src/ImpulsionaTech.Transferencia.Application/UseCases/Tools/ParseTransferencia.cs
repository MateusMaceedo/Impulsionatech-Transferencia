using ImpulsionaTech.Transferencia.Application.Responses;
using ImpulsionaTech.Transferencia.Domain.Entities;

namespace ImpulsionaTech.Transferencia.Application.UseCases.Tools
{
  public partial class EntityToModelProfile
  {
    public static TransferenciaEntity ParseTransferencia(TransferenciaResponse response, string id)
    {
      return
          new TransferenciaEntity
          (
              contaOrigem: response.ContaOrigem,
              contaDestino: response.AgenciaDestino,
              nomeOrigem: response.NomeOrigem,
              nomeDestino: response.AgenciaOrigem,
              agenciaOrigem: response.AgenciaOrigem,
              agenciaDestino: response.AgenciaDestino,
              valor: response.Valor
          );
    }
  }
}
