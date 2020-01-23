using ProjetoContaBancaria.Domain.Entities;

namespace ProjetoContaBancaria.Domain.Interfaces.Service
{
    public interface IClienteService
    {
        string Post(Cliente cliente);
        Cliente Get(string email);
        void Put(Cliente cliente);
        void Delete(int Num_Cpf);
    }
}
