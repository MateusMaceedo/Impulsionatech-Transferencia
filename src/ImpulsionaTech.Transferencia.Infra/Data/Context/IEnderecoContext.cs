using ImpulsionaTech.Transferencia.Domain.Entities;
using MongoDB.Driver;

namespace ImpulsionaTech.Transferencia.Infra.Data.Context
{
  public interface IEnderecoContext
  {
     IMongoCollection<EnderecoEntity> Endereco { get; }
  }
}
