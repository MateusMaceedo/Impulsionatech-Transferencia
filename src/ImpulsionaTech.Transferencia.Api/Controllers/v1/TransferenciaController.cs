using ImpulsionaTech.Transferencia.Api.Controllers.Base;
using ImpulsionaTech.Transferencia.Api.Tools;
using ImpulsionaTech.Transferencia.Application.UseCases.Commands;
using ImpulsionaTech.Transferencia.Application.UseCases.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace ImpulsionaTech.Transferencia.Api.Controllers.v1
{
  [Route("v1/[controller]/")]
  public class TransferenciaController : BaseController
  {
    [HttpPost("PostTransferencia/")]
    public async Task<ActionResult> GetCep([FromBody] RealizarTransferenciaCommand transferenciaCommand, [FromServices] RealizarTransferenciaHandler handler)
    {
      return new ParseRequestResult().ParseToActionResult(await handler.Handle(transferenciaCommand));
    }
  }
}
