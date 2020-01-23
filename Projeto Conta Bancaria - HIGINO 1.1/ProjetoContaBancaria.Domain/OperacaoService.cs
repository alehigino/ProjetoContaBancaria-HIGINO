using ProjetoContaBancaria.Domain.Entities;
using ProjetoContaBancaria.Domain.Interfaces.Repository;
using ProjetoContaBancaria.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoContaBancaria.Domain
{
    public class OperacaoService : IOperacaoService
    {
        private readonly IOperacaoRepository _operacaoRepository;

        public OperacaoService(IOperacaoRepository operacaoRepository)
        {
            _operacaoRepository = operacaoRepository;
        }
        public void RealizarOperacao(Operacao operacao)
        {
            int i;
            if (operacao.Nom_Tipo == "Deposito")
                _operacaoRepository.Deposito(operacao);
            else if (operacao.Nom_Tipo == "Saque")
                _operacaoRepository.Saque(operacao);
            else if (operacao.Nom_Tipo == "Transferencia")
                i = _operacaoRepository.Transferencia(operacao, operacao.Num_Aux);
        }
    }
}
