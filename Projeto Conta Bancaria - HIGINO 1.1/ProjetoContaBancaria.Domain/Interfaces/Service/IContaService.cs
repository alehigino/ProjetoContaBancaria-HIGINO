using ProjetoContaBancaria.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoContaBancaria.Domain.Interfaces.Service
{
    public interface IContaService
    {
        string Post(Conta conta);
        Conta Get(int Num_Conta);
        void Delete(int Num_Conta);
        List<Conta> GetContas(int Num_Cpf);
    }
}
