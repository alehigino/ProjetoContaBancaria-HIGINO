using ProjetoContaBancaria.Domain.Entities;
using ProjetoContaBancaria.Domain.Interfaces.Service;
using System.Web.Http;

namespace ProjetoContaBancaria.API.Controllers
{
    public class ClienteController : ApiController
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public IHttpActionResult Get(Cliente cliente)
        {
            _clienteService.Get(cliente.Nom_Email);
            return Ok();
        }

        public IHttpActionResult Post(Cliente cliente)
        {
            _clienteService.Post(cliente);
            return Ok();
        }

        public IHttpActionResult Put(Cliente cliente)
        {
            _clienteService.Put(cliente);
            return Ok();
        }

        public IHttpActionResult Delete(Cliente cliente)
        {
            _clienteService.Delete(cliente);
            return Ok();
        }
    }
}