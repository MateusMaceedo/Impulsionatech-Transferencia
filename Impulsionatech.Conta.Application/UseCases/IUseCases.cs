using System.Threading.Tasks;

namespace Impulsionatech.Conta.Application.UseCases
{
    public interface IUseCases<TRequest>
    {
        void Executar(IRequest request);
    }

    public interface IUseCases<TRequest, TResponse>
    {
        TResponse Executar(IRequest request);
    }

    public interface IUseCases<TRequest, TResponse>
    {
        Task<TResponse> Executar(TRequest param);
    }

    public interface IUseCases<TRequest>
    {
        Task Executar(TRequest param);
    }

    public interface IUseCaseWithoutParamAsync<TResponse>
    {
        Task<TResponse> Executar();
    }
}
