using ProjetoContaBancaria.Domain.Entities;
using ProjetoContaBancaria.Domain.Interfaces.Service;
using System.Web.Http;

namespace ProjetoContaBancaria.Controllers
{
    public class ContaController : ApiController
    {
        private readonly IContaService _contaService;

        public ContaController(IContaService contaService)
        {
            _contaService = contaService;
        }

        public IHttpActionResult Get(int Num_Conta)
        {
            return Ok(_contaService.Get(Num_Conta));
        }

        public IHttpActionResult Post(Conta conta)
        {
            return Ok(_contaService.Post(conta));
        }

        public IHttpActionResult Delete(int Num_Conta)
        {
            _contaService.Delete(Num_Conta);
            return Ok();
        }
    }
}
