using ProjetoContaBancaria.Domain.Entities;

namespace ProjetoContaBancaria.Domain.Interfaces.Repository
{
    public interface IClienteRepository
        {
            string Post(Cliente cliente);
            Cliente Get(string email);
            void Put(Cliente cliente);
            void Delete(Cliente cliente);
            int VerificaDados(Cliente cliente);
        }
}
