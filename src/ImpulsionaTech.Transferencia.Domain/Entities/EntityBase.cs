using Flunt.Notifications;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ImpulsionaTech.Transferencia.Domain.Entities
{
  [Serializable]
  [BsonIgnoreExtraElements]
  public abstract class EntityBase
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
    public DateTime DataTransferencia { get; set; } = DateTime.Now;

    [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
    public DateTime? AlteradoEm { get; set; }
  }

  [Serializable]
  [BsonIgnoreExtraElements]
  public abstract class EntityBase<TValidation> : EntityBase
    where TValidation : Notifiable<Notification>
  {
    [BsonIgnore]
    private TValidation Validator => (TValidation)Activator.CreateInstance(typeof(TValidation), this);

    [BsonIgnore]
    public IEnumerable<Notification> Notifications => Validator.Notifications;

    [BsonIgnore]
    public bool IsValid => Validator.IsValid;
  }
}
