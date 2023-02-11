using ImpulsionaTech.Transferencia.Api.Controllers.Base;
using ImpulsionaTech.Transferencia.Api.Tools;
using ImpulsionaTech.Transferencia.Application.UseCases.Commands;
using ImpulsionaTech.Transferencia.Application.UseCases.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace ImpulsionaTech.Transferencia.Api.Controllers.v1
{
  [Route("v1/[controller]/")]
  public class EnderecoController : BaseController
  {
    [HttpPost("GetEndereco/")]
    public async Task<ActionResult> GetCep([FromBody] ProcessarEnderecoCommand cepCommand, [FromServices] ProcessarEnderecoHandler handler)
    {
      return new ParseRequestResult().ParseToActionResult(await handler.Handle(cepCommand));
    }
  }
}
