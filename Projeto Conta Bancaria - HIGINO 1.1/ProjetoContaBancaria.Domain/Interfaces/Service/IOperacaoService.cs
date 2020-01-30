using ProjetoContaBancaria.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoContaBancaria.Domain.Interfaces.Service
{
    public interface IOperacaoService
    {
        void Deposito(Operacao operacao);
        void Saque(Operacao operacao);
        int Transferencia(Operacao operacao, int Num_Conta_Env);
        List<Operacao> Extrato(int Num_Conta);
    }
}
