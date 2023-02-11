using ImpulsionaTech.Transferencia.Domain.Entities;
using ImpulsionaTech.Transferencia.Infra.Data.Context;
using MongoDB.Driver;

namespace ImpulsionaTech.Transferencia.Infra.Repositories
{
  public class ConsultaEnderecoRepository : IConsultaEnderecoRepository
  {
    private readonly EnderecoContext _context;
    public ConsultaEnderecoRepository(EnderecoContext context)
    {
      _context = context;
    }

    public async Task CreateEndereco(EnderecoEntity endereco)
    {
      await _context.Endereco.InsertOneAsync(endereco);
    }

    public async Task<bool> DeleteEndereco(string id)
    {
      FilterDefinition<EnderecoEntity> filter = Builders<EnderecoEntity>.Filter.Eq(p => p.Id, id);

      DeleteResult deleteResult = await _context.Endereco.DeleteOneAsync(filter);

      return deleteResult.IsAcknowledged
          && deleteResult.DeletedCount > 0;
    }

    public async Task<EnderecoEntity> GetEndereco(string id)
    {
      return await _context.Endereco.Find(p => p.Id == id).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<EnderecoEntity>> GetEnderecoByCep(string cep)
    {
      FilterDefinition<EnderecoEntity> filter = Builders<EnderecoEntity>.Filter
              .Eq(p => p.Cep, cep);

      return await _context.Endereco.Find(filter).ToListAsync();
    }

    public async Task<IEnumerable<EnderecoEntity>> GetEnderecoByBairro(string bairro)
    {
      FilterDefinition<EnderecoEntity> filter = Builders<EnderecoEntity>.Filter
              .Eq(p => p.Bairro, bairro);

      return await _context.Endereco.Find(filter).ToListAsync();
    }

    public async Task<IEnumerable<EnderecoEntity>> GetEnderecos()
    {
      return await _context.Endereco.Find(p => true).ToListAsync();
    }

    public async Task<bool> UpdateEndereco(EnderecoEntity endereco)
    {
      var updateResult = await _context.Endereco.ReplaceOneAsync(
        filter: g => g.Id == endereco.Id, replacement: endereco);

      return updateResult.IsAcknowledged
        && updateResult.ModifiedCount > 0;
    }
  }
}
