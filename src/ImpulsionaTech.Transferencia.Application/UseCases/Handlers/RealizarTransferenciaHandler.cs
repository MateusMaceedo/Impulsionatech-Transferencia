using System.Net;
using ImpulsionaTech.Transferencia.Application.Repositories.External;
using ImpulsionaTech.Transferencia.Application.Responses;
using ImpulsionaTech.Transferencia.Application.Results;
using ImpulsionaTech.Transferencia.Application.UseCases.Commands;
using ImpulsionaTech.Transferencia.Application.UseCases.Tools;

namespace ImpulsionaTech.Transferencia.Application.UseCases.Handlers
{
  public class RealizarTransferenciaHandler : IHandler<RealizarTransferenciaCommand>
  {
    private readonly ITransferenciaRepository _repository;
    public RealizarTransferenciaHandler(ITransferenciaRepository repository)
    {
      _repository = repository;
    }

    public async Task<RequestResult> Handle(RealizarTransferenciaCommand command)
    {
      if (string.IsNullOrEmpty(command.Id))
      {
        var cepResult = await _repository.PostTransferencia(command.Id);

        if (cepResult.StatusCode != (int)HttpStatusCode.OK)
          return cepResult;

        var response = cepResult.Data as TransferenciaResponse;
        var transferencia = EntityToModelProfile.ParseTransferencia(response, command.NomeOrigem);

        if (!transferencia.IsValid)
          return new RequestResult().BadRequest("Verifique os campos e tente novamente", transferencia);

        return new RequestResult().Ok(transferencia);
      }

      throw new Exception("Verifique os campos e tente novamente");
    }
  }
}
