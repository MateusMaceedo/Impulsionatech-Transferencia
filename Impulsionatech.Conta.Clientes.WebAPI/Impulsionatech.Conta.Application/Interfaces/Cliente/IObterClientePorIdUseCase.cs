using System;
using System.Collections.Generic;
using System.Text;

namespace Impulsionatech.Conta.Application.Interfaces.Cliente
{
    public interface IObterClientePorIdUseCase : IUseCaseAsync<int, ClienteResponse>
    {
    }
}
