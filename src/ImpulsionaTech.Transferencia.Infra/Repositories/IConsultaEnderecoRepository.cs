using ImpulsionaTech.Transferencia.Domain.Entities;

namespace ImpulsionaTech.Transferencia.Infra.Repositories
{
  public interface IConsultaEnderecoRepository
  {
    Task<IEnumerable<EnderecoEntity>> GetEnderecos();
    Task<EnderecoEntity> GetEndereco(string id);
    Task<IEnumerable<EnderecoEntity>> GetEnderecoByCep(string cep);
    Task<IEnumerable<EnderecoEntity>> GetEnderecoByBairro(string bairro);
    Task CreateEndereco(EnderecoEntity endereco);
    Task<bool> UpdateEndereco(EnderecoEntity endereco);
    Task<bool> DeleteEndereco(string id);
  }
}
