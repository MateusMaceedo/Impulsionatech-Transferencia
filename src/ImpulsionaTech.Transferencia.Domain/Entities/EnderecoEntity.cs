namespace ImpulsionaTech.Transferencia.Domain.Entities
{
  public class EnderecoEntity : EntityBase
  {
    //TODO: Testar como protected
    public EnderecoEntity()
    {

    }
    // Aberta para extensão e fechada para modificação
    public EnderecoEntity(string cep, string logradouro, string unidadeFederacao, int numeroLogradouro, string bairro)
    {
      Cep = cep;
      Logradouro = logradouro;
      UnidadeFederacao = unidadeFederacao;
      NumeroLogradouro = numeroLogradouro;
      Bairro = bairro;
    }

    public string Cep { get; set; }
    public string Logradouro { get; set; }
    public string UnidadeFederacao { get; set; }
    public int NumeroLogradouro { get; set; }
    public string Bairro { get; set; }
    public bool IsValid => Validate();
    public bool IsFreteGratis => IsElegivelFreteGratis();

    private bool Validate()
    {
      return
          this.Cep.Length == 9;
    }
    private bool IsElegivelFreteGratis()
    {
      return
          this.UnidadeFederacao.ToUpper() == "SP"
          ||
          this.UnidadeFederacao.ToUpper() == "MG";
    }
  }
}
