using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Impulsionatech.Conta.Application.Interfaces.Conta
{
    public interface IContaBaseUseCase
    {
        Task<ContaEntity> ObterContaPorId(int idConta);
    }
}
