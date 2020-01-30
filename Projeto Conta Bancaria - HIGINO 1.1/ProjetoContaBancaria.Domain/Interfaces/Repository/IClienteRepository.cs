using ProjetoContaBancaria.Domain.Entities;

namespace ProjetoContaBancaria.Domain.Interfaces.Repository
{
    public interface IClienteRepository
    {
        string Post(Cliente cliente);
        Cliente Get(string Nom_Consulta);
        void Put(Cliente cliente);
        void Delete(int Num_Cpf);
        int VerificaDados(Cliente cliente);
        int ConsLogin(string Nom_Consulta, string Nom_Senha);
    }
}
