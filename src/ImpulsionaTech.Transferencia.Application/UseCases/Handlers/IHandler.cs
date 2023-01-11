using ImpulsionaTech.Transferencia.Application.Results;
using ImpulsionaTech.Transferencia.Application.UseCases.Commands;

namespace ImpulsionaTech.Transferencia.Application.UseCases.Handlers
{
  public interface IHandler<T>
    where T : ICommand
  {
     Task<RequestResult> Handle(T command);
  }
}
