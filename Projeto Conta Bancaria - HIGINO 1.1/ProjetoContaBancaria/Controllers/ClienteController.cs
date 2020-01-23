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
        [HttpGet, Route(template:"api/cliente/conslogin")]
        public IHttpActionResult ConsLogin(string Nom_Consulta, string Nom_Senha)
        {
            return Ok(_clienteRepository.ConsLogin(Nom_Consulta, Nom_Senha));
        }

        public IHttpActionResult Get(string Nom_Email)
        {
            return Ok(_clienteService.Get(Nom_Email));
        }

        public IHttpActionResult Post(Cliente cliente)
        {
            return Ok(_clienteService.Post(cliente));
        }

        public IHttpActionResult Put(Cliente cliente)
        {
            _clienteService.Put(cliente);
            return Ok();
        }

        public IHttpActionResult Delete(int Num_Cpf)
        {
            _clienteService.Delete(Num_Cpf);
            return Ok();
        }
    }
}