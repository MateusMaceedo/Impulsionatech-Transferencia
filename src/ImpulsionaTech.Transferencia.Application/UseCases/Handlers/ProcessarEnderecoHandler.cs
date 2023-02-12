using System.Net;
using ImpulsionaTech.Transferencia.Application.Responses;
using ImpulsionaTech.Transferencia.Application.Results;
using ImpulsionaTech.Transferencia.Application.UseCases.Commands;
using ImpulsionaTech.Transferencia.Application.UseCases.Tools;
using ImpulsionaTech.Transferencia.Domain.Interfaces.Externals;

namespace ImpulsionaTech.Transferencia.Application.UseCases.Handlers
{
  public class ProcessarEnderecoHandler : IHandler<ProcessarEnderecoCommand>
  {
    private readonly IEnderecoRepository _repository;
    public ProcessarEnderecoHandler(IEnderecoRepository repository)
    {
      _repository = repository;
    }

    public async Task<RequestResult> Handle(ProcessarEnderecoCommand command)
    {
      var cepResult = await _repository.GetCep(command.Cep);

      if (cepResult.StatusCode != (int)HttpStatusCode.OK)
        return cepResult;

      var cepDTO = cepResult.Data as EnderecoResponse;
      var endereco = EntityMapper.ParseEndereco(cepDTO, command.NumeroLogradouro);

      if (!endereco.IsValid)
        return new RequestResult().BadRequest("Verifique os campos e tente novamente", endereco);

      return new RequestResult().Ok(endereco);
    }
  }
}
