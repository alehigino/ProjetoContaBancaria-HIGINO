using ProjetoContaBancaria.Domain.Entities;
using ProjetoContaBancaria.Domain.Interfaces.Repository;
using ProjetoContaBancaria.Domain.Interfaces.Service;

namespace ProjetoContaBancaria.Domain
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public string Post(Cliente cliente)
        {
            int i = _clienteRepository.VerificaDados(cliente);

            if(i == 0)
                 _clienteRepository.Post(cliente);

            return "Cliente Cadastrado com Sucesso";
        }
        public Cliente Get(string Nom_Email)
        {
            return _clienteRepository.Get(Nom_Email);
        }
        public void Put(Cliente cliente)
        {
            _clienteRepository.Put(cliente);
        }
        public void Delete(int Num_Cpf)
        {
            _clienteRepository.Delete(Num_Cpf);
        }
    }
}
