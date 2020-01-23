using ProjetoContaBancaria.Domain.Entities;

namespace ProjetoContaBancaria.Domain.Interfaces.Service
{
    public interface IOperacaoService
    {
        void RealizarOperacao(Operacao operacao);
    }
}
