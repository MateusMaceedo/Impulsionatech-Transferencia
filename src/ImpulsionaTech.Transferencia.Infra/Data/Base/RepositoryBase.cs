using System.Linq.Expressions;
using ImpulsionaTech.Transferencia.Domain.Entities;
using MongoDB.Driver;

namespace ImpulsionaTech.Transferencia.Infra.Data.Base
{
  public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
    where TEntity : EntityBase
  {
    public readonly IMongoCollection<TEntity> EntityMongoCollection;

    public RepositoryBase(string collectionName, IDbConnectionString settings)
    {
      var mongoClientSettings = MongoClientSettings.FromUrl(new MongoUrl(settings.ConnectionString));
      mongoClientSettings.SslSettings.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12;

      var client = new MongoClient(mongoClientSettings);
      var database = client.GetDatabase(settings.DatabaseName);

      EntityMongoCollection = database.GetCollection<TEntity>(name: collectionName);
    }

    public virtual TEntity Buscar(string id) =>
        EntityMongoCollection.Find(s => s.Id == id).FirstOrDefault();

    public virtual async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> query)
    {
      return (await EntityMongoCollection.FindAsync(query)).ToList();
    }

    public virtual IMongoCollection<TEntity> GetEntityMongoCollection()
    {
      return EntityMongoCollection;
    }

    public virtual TEntity Inserir(TEntity entity, IMongoCollection<TEntity> entityMongoCollection)
    {
      entity.AlteradoEm = DateTime.Now;
      entityMongoCollection.InsertOne(entity);
      return entity;
    }

    public virtual void Inserir(IEnumerable<TEntity> entities) => EntityMongoCollection.InsertMany(entities);

    public virtual void Alterar(string id, TEntity entityIn)
    {
      entityIn.AlteradoEm = DateTime.Now;
      EntityMongoCollection.ReplaceOne(entity => entity.Id == id, entityIn);
    }

    public virtual void Remover(TEntity entityIn) =>
            EntityMongoCollection.DeleteOne(entity => entity.Id == entityIn.Id);

    public virtual void Remover(string id) =>
    EntityMongoCollection.DeleteOne(entity => entity.Id == id);
  }
}
