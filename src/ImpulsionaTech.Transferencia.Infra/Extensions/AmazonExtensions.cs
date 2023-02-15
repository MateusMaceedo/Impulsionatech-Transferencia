using Amazon;
using ImpulsionaTech.Transferencia.Domain.Entities;
using ImpulsionaTech.Transferencia.Domain.Enum;
using Newtonsoft.Json;

namespace ImpulsionaTech.Transferencia.Infra.Extensions
{
  public static class AmazonExtensions
  {
    public static async Task EnviarParaFila(EnumFilasSQS fila, TransferenciaEntity entity)
    {
      var json = JsonConvert.SerializeObject(entity);
      var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
      var request = new SendMessageRequest
      {
        QueueUrl = $"https://sqs.sa-east-1.amazonaws.com/355552168393/{fila}",
        MessageBody = json
      };

      await client.SendMessageAsync(request);
    }
  }
}
