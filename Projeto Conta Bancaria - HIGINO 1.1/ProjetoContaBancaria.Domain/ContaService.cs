using ProjetoContaBancaria.Domain.Entities;
using ProjetoContaBancaria.Domain.Interfaces.Repository;
using ProjetoContaBancaria.Domain.Interfaces.Service;
using System.Collections.Generic;

namespace ProjetoContaBancaria.Domain
{
    public class ContaService : IContaService
    {
        private readonly IContaRepository _contaRepository;

        public ContaService(IContaRepository contaRepository)
        {
            _contaRepository = contaRepository;
        }
        public void Delete(int Num_Conta)
        {
            _contaRepository.Delete(Num_Conta);
        }

        public Conta Get(int Num_Conta)
        {
            return _contaRepository.Get(Num_Conta);
        }

        public List<Conta> GetContas(int Num_Cpf)
        {
            return _contaRepository.GetContas(Num_Cpf);
        }

        public string Post(Conta conta)
        {
            _contaRepository.Post(conta);
            return "";
        }

    }
}
