using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Impulsionatech.Conta.Application.Interfaces.Cliente
{
    public interface IClienteBaseUseCase 
    {
        Task<ClienteEntity> ObterClientePorId(int idCliente);
    }
}
