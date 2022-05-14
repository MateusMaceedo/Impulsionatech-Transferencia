using System;
using System.Collections.Generic;
using System.Text;

namespace Impulsionatech.Conta.Application.Interfaces.Conta
{
    public interface IObterContasPorFlitrosUseCase : IUseCaseAsync<ObterContasPorFiltrosRequest, List<ContaResponse>>
    {

    }
}
