using ImpulsionaTech.Transferencia.Domain.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace ImpulsionaTech.Transferencia.Infra.Data.Context
{
  public class EnderecoContext : IEnderecoContext
  {
    public EnderecoContext(IConfiguration configuration)
    {
       var client = new MongoClient(configuration.GetValue<string>
                ("DatabaseSettings:ConnectionString"));

       var database = client.GetDatabase(configuration.GetValue<string>
                ("DatabaseSettings:DatabaseName"));

       Endereco = database.GetCollection<EnderecoEntity>(configuration.GetValue<string>
                ("DatabaseSettings:CollectionName"));

       EnderecoContextSeed.SeedData(Endereco);
    }

    public IMongoCollection<EnderecoEntity> Endereco { get; }
  }
}
