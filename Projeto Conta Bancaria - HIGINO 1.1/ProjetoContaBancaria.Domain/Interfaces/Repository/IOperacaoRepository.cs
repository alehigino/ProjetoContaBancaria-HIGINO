using ProjetoContaBancaria.Domain.Entities;

namespace ProjetoContaBancaria.Domain.Interfaces.Repository
{
    public interface IOperacaoRepository
    {
        void Deposito(Operacao operacao);
        void Saque(Operacao operacao);
        int Transferencia(Operacao operacao, int Num_Conta_Env);
    }
}
