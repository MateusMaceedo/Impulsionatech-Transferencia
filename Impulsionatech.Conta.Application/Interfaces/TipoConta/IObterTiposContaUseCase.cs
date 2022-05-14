using System;
using System.Collections.Generic;
using System.Text;

namespace Impulsionatech.Conta.Application.Interfaces.TipoConta
{
    public interface IObterTiposContaUseCase : IUseCaseWithoutParamAsync<List<TipoContaResponse>>
    {
    }
}
