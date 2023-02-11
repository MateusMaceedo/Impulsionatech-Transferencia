using ImpulsionaTech.Transferencia.Application.Results;
using Microsoft.Extensions.Configuration;

namespace ImpulsionaTech.Transferencia.Domain.Interfaces.Externals
{
  public interface IEnderecoRepository
  {
    Task<RequestResult> GetCep(string cep);
  }
}
