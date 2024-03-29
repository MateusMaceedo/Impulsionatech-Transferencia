namespace ImpulsionaTech.Transferencia.Domain.Entities
{
  public class TransferenciaEntity : EntityBase
  {
    public TransferenciaEntity(string nomeOrigem, string nomeDestino, string contaOrigem, string contaDestino, string agenciaOrigem, string agenciaDestino, decimal valor)
    {
      nomeOrigem = NomeOrigem;
      nomeDestino = NomeDestino;
      contaOrigem = ContaOrigem;
      contaDestino = ContaDestino;
      agenciaOrigem = AgenciaOrigem;
      agenciaDestino = AgenciaDestino;
      valor = Valor;
    }

    public string NomeOrigem { get; set; }
    public string NomeDestino { get; set; }
    public string ContaOrigem { get; set; }
    public string ContaDestino { get; set; }
    public string AgenciaOrigem { get; set; }
    public string AgenciaDestino { get; set; }
    public decimal Valor { get; set; }
    public bool IsValid => Validate();

    private bool Validate()
    {
      return
          this.Id.Length == 9;
    }
    private bool IsElegivelFreteGratis()
    {
      return
          this.AgenciaOrigem.ToUpper() == "1530"
          ||
          this.AgenciaOrigem.ToUpper() == "1540";
    }
  }
}
