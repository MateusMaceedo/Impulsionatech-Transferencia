using Microsoft.AspNetCore.Mvc;

namespace ImpulsionaTech.Transferencia.Api.Controllers.Base
{
    [ApiController]
    [ApiVersion("1")]
    [Produces("application/json")]
    [Route("api/v{api-version:apiVersion}/[controller]")]
    public abstract class BaseController : ControllerBase
    {
    }
}
