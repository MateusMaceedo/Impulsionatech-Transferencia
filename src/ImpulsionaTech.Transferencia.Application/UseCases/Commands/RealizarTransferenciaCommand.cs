namespace ImpulsionaTech.Transferencia.Application.UseCases.Commands
{
  public class RealizarTransferenciaCommand : ICommand
  {
    public string Id { get; set; }
    public string NomeOrigem { get; set; }

    public RealizarTransferenciaCommand(string id, string nomeOrigem)
    {
        Id = id;
        NomeOrigem = nomeOrigem;
    }
  }
}
