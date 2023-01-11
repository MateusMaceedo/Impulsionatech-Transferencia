using ImpulsionaTech.Transferencia.Api.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace ImpulsionaTech.Transferencia.Api.Controllers.v1
{
    [Route("[controller]")]
    public class TransferenciaController : BaseController
    {
        private readonly ILogger<TransferenciaController> _logger;

        public TransferenciaController(ILogger<TransferenciaController> logger)
        {
            _logger = logger;
        }
    }
}
