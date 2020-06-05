using ProjetoContaBancaria.Domain.Entities;
using ProjetoContaBancaria.Domain.Interfaces.Repository;
using ProjetoContaBancaria.Domain.Interfaces.Service;
using System.Web.Http;

namespace ProjetoContaBancaria.API.Controllers
{
    public class ClienteController : ApiController
    {
        private readonly IClienteService _clienteService;
        private readonly IClienteRepository _clienteRepository;

        public ClienteController(IClienteService clienteService, IClienteRepository clienteRepository)
        {
            _clienteService = clienteService;
            _clienteRepository = clienteRepository;
        }
        public void Delete(int Num_Cpf)
        {
            _clienteService.Delete(Num_Cpf);
        }

        public Cliente Get(string Nom_Consulta)
        {
            return _clienteService.Get(Nom_Consulta);
        }

        public string Post(Cliente cliente)
        {
            _clienteService.Post(cliente);
            return "";
        }

        public void Put(Cliente cliente)
        {
            _clienteService.Put(cliente);
        }
        [HttpGet, Route(template: "api/cliente/conslogin")]
        public int ConsLogin(string Nom_Consulta, string Nom_Senha)
        {
            return _clienteRepository.ConsLogin(Nom_Consulta, Nom_Senha);
        }

    }
}
