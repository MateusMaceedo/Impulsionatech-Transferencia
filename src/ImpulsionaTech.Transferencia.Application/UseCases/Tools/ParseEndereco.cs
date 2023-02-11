using ImpulsionaTech.Transferencia.Application.Responses;
using ImpulsionaTech.Transferencia.Domain.Entities;

namespace ImpulsionaTech.Transferencia.Application.UseCases.Tools
{
  public partial class EntityMapper
  {
    public static EnderecoEntity ParseEndereco(EnderecoResponse response, int numeroLogradouro)
    {
      return
          new EnderecoEntity
          (
              cep: response.Cep,
              logradouro: response.Logradouro,
              unidadeFederacao: response.Uf,
              numeroLogradouro: numeroLogradouro,
              bairro: response.Bairro
          );
    }
  }
}
