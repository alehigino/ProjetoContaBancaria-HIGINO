using ProjetoContaBancaria.Domain.Entities;

namespace ProjetoContaBancaria.Domain.Interfaces.Repository
{
    public interface IContaRepository
    {
        string Post(Conta conta);
        Conta Get(int Num_Conta);
        void Delete(int Num_Conta);
    }
}
