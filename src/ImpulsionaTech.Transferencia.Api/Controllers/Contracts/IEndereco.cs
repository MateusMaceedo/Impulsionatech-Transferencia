using ImpulsionaTech.Transferencia.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ImpulsionaTech.Transferencia.Api.Controllers.Contracts
{
  public interface IEndereco
  {
     Task<ActionResult<IEnumerable<EnderecoEntity>>> GetEndereco();
     Task<ActionResult<EnderecoEntity>> GetEnderecosPorId(string id);
     Task<ActionResult<IEnumerable<EnderecoEntity>>> GetEnderecosPorBairro(string bairro);
     Task<ActionResult<EnderecoEntity>> CreateEndereco([FromBody] EnderecoEntity endereco);
     Task<IActionResult> UpdateEndereco([FromBody] EnderecoEntity endereco);
     Task<IActionResult> DeleteEnderecoPorId(string id);
  }
}
