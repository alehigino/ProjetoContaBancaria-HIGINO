using ProjetoContaBancaria.Domain.Entities;
using ProjetoContaBancaria.Domain.Interfaces.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace ProjetoContaBancaria.API.Controllers
{
    public class OperacaoController : ApiController
    {
        private readonly IOperacaoService _operacaoService;

        public OperacaoController(IOperacaoService operacaoService)
        {
            _operacaoService = operacaoService;
        }
        [HttpPost, Route(template: "api/operacao/deposito")]
        public void Deposito(Operacao operacao)
        {
            _operacaoService.Deposito(operacao);
        }
        [HttpGet, Route(template: "api/operacao/extrato")]
        public List<Operacao> Extrato(int Num_Conta)
        {
            return _operacaoService.Extrato(Num_Conta);
        }
        [HttpPost, Route(template: "api/operacao/saque")]
        public void Saque(Operacao operacao)
        {
            _operacaoService.Saque(operacao);
        }
        [HttpPost, Route(template: "api/operacao/transferencia")]
        public int Transferencia(Operacao operacao, int Num_Conta_Env)
        {
            return _operacaoService.Transferencia(operacao, Num_Conta_Env);
        }
    }
}
