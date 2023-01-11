using System.Net;
using ImpulsionaTech.Transferencia.Application.Results;
using Microsoft.AspNetCore.Mvc;

namespace ImpulsionaTech.Transferencia.Api.Tools
{
  public class ParseRequestResult : Controller
  {
    public ActionResult ParseToActionResult(RequestResult request)
    {
      switch (request.StatusCode)
      {
        case (int)HttpStatusCode.OK:
          return Ok(request);
        case (int)HttpStatusCode.BadRequest:
          return BadRequest(request);
        default:
          return BadRequest(request);
      }
    }
  }
}
