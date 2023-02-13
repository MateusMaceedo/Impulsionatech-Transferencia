using ImpulsionaTech.Transferencia.Api.Controllers.Base;
using ImpulsionaTech.Transferencia.Api.Controllers.Contracts;
using ImpulsionaTech.Transferencia.Domain.Entities;
using ImpulsionaTech.Transferencia.Infra.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ImpulsionaTech.Transferencia.Api.Controllers.v1
{
  [Route("api/v1/[controller]/")]
  public class EnderecoController : BaseController, IEndereco
  {
    private readonly IConsultaEnderecoRepository _repository;
    private readonly ILogger<EnderecoController> _logger;


    public EnderecoController(
      IConsultaEnderecoRepository repository,
      ILogger<EnderecoController> logger)
    {
      _repository = repository ?? throw new ArgumentNullException(nameof(repository));
      _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    [HttpGet("GetEndereco/")]
    [ProducesResponseType(typeof(IEnumerable<EnderecoEntity>), StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<EnderecoEntity>>> GetEndereco()
    {
      _logger.LogInformation("Recebido requisição para GetEndereco");
      var enderecos = await _repository.GetEnderecos();
      return Ok(enderecos);
    }

    [HttpGet("GetEnderecosPorId/{id:length(24)}", Name = "GetEndereco")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(IEnumerable<EnderecoEntity>), StatusCodes.Status200OK)]
    public async Task<ActionResult<EnderecoEntity>> GetEnderecosPorId(string id)
    {
      _logger.LogInformation("Recebido requisição para GetEnderecosPorId");
      var enderecos = await _repository.GetEndereco(id);
      if (enderecos is null)
      {
        return NotFound();
      }

      return Ok(enderecos);
    }

    [Route("[action]/{bairro}", Name = "GetEnderecosPorBairro")]
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<EnderecoEntity>))]
    public async  Task<ActionResult<IEnumerable<EnderecoEntity>>> GetEnderecosPorBairro(string bairro)
    {
      _logger.LogInformation("Recebido requisição para GetEnderecosPorBairro");
      if(bairro is null)
           return BadRequest("Invalid bairro");

      var endereco = await _repository.GetEnderecoByBairro(bairro);

      return Ok(endereco);
    }

    [HttpPost]
    [ProducesResponseType(typeof(EnderecoEntity), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<EnderecoEntity>> CreateEndereco([FromBody] EnderecoEntity endereco)
    {
      _logger.LogInformation("Recebido requisição para CreateEndereco");
      if(endereco is null)
         return BadRequest("Invalid endereco");

      await _repository.CreateEndereco(endereco);

      return CreatedAtRoute("GetEndereco", new {id = endereco.Id}, endereco);
    }

    [HttpPut]
    [ProducesResponseType(typeof(EnderecoEntity), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateEndereco([FromBody] EnderecoEntity endereco)
    {
      _logger.LogInformation("Recebido requisição para UpdateEndereco");
      if(endereco is null)
        return BadRequest("Invalid endereco");

      return Ok(await _repository.UpdateEndereco(endereco));
    }

    [HttpDelete("{id:length(24)}", Name = "DeleteEndereco")]
    [ProducesResponseType(typeof(EnderecoEntity), StatusCodes.Status200OK)]
    public async Task<IActionResult> DeleteEnderecoPorId(string id)
    {
       _logger.LogInformation("Recebido requisição para DeleteEnderecoPorId");
       return Ok(await _repository.DeleteEndereco(id));
    }
  }
}
