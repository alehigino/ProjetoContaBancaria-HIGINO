using ProjetoContaBancaria.Domain.Entities;
using ProjetoContaBancaria.Domain.Interfaces.Repository;
using ProjetoContaBancaria.Domain.Interfaces.Service;
using System.Collections.Generic;

namespace ProjetoContaBancaria.Domain
{
    public class OperacaoService : IOperacaoService
    {
        private readonly IOperacaoRepository _operacaoRepository;

        public OperacaoService(IOperacaoRepository operacaoRepository)
        {
            _operacaoRepository = operacaoRepository;
        }

        public void Deposito(Operacao operacao)
        {
            _operacaoRepository.Deposito(operacao);
        }

        public List<Operacao> Extrato(int Num_Conta)
        {
            return _operacaoRepository.Extrato(Num_Conta);
        }

        public void Saque(Operacao operacao)
        {
            _operacaoRepository.Saque(operacao);
        }

        public int Transferencia(Operacao operacao, int Num_Conta_Env)
        {
            return _operacaoRepository.Transferencia(operacao, Num_Conta_Env);
        }
    }
}
