using ProjetoContaBancaria.Domain.Entities;
using ProjetoContaBancaria.Domain.Interfaces.Service;
using System.Web.Http;

namespace ProjetoContaBancaria.Controllers
{
    public class OperacaoController : ApiController
    {
        private readonly IOperacaoService _operacaoService;

        public OperacaoController(IOperacaoService operacaoService)
        {
            _operacaoService = operacaoService;
        }
        [HttpPost, Route(template: "api/operacao/deposito")]
        public IHttpActionResult Deposito(Operacao operacao)
        {
            _operacaoService.RealizarOperacao(operacao);
            return Ok();
        }
        [HttpPost, Route(template: "api/operacao/saque")]
        public IHttpActionResult Saque(Operacao operacao)
        {
            _operacaoService.RealizarOperacao(operacao);
            return Ok();
        }
        [HttpPost, Route(template: "api/operacao/transferencia")]
        public IHttpActionResult Transferencia(Operacao operacao)
        {
            _operacaoService.RealizarOperacao(operacao);
            return Ok();
        }
    }
}
