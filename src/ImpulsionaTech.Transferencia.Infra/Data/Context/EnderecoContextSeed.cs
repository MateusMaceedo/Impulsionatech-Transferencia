using ImpulsionaTech.Transferencia.Domain.Entities;
using MongoDB.Driver;

namespace ImpulsionaTech.Transferencia.Infra.Data.Context
{
  public class EnderecoContextSeed
  {
    public static void SeedData(IMongoCollection<EnderecoEntity> enderecoCollection)
    {
       bool existEndereco = enderecoCollection.Find(p => true).Any();
       if(!existEndereco)
       {
          enderecoCollection.InsertMany(GetMyEndereco());
       }
    }

    private static IEnumerable<EnderecoEntity> GetMyEndereco()
    {
       return new List<EnderecoEntity>()
       {
          new EnderecoEntity()
          {
            Id = "f1640e49-e145-44c2-b243-894bd0ab92a6",
            AlteradoEm = DateTime.UtcNow,
            Bairro = "São Paulo",
            Cep = "08589350",
            DataTransferencia = DateTime.UtcNow,
            Logradouro = "Rua Agata",
            NumeroLogradouro = 125,
            UnidadeFederacao = "São Paulo"
          }
       };
    }
  }
}
