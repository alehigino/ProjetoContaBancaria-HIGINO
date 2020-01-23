using ProjetoContaBancaria.Domain.Entities;

namespace ProjetoContaBancaria.Domain.Interfaces.Service
{
    public interface IContaService
    {
        string Post(Conta conta);
        Conta Get(int Num_Conta);
        void Delete(int Num_Conta);
    }
}
