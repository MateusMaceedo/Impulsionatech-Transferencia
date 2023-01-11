using ImpulsionaTech.Transferencia.Application.Results;

namespace ImpulsionaTech.Transferencia.Application.Repositories.External
{
  public interface ITransferenciaRepository
  {
    Task<RequestResult> PostTransferencia(string id);
  }
}
