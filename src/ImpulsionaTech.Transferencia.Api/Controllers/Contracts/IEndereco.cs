using ImpulsionaTech.Transferencia.Application.UseCases.Commands;
using ImpulsionaTech.Transferencia.Application.UseCases.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace ImpulsionaTech.Transferencia.Api.Controllers.Contracts
{
  public interface IEndereco
  {
     Task<ActionResult> PostCep([FromBody] ProcessarEnderecoCommand cepCommand, [FromServices] ProcessarEnderecoHandler handler);
  }
}
