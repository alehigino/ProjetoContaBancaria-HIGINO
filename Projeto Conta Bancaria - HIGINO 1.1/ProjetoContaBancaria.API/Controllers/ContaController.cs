using ProjetoContaBancaria.Domain.Entities;
using ProjetoContaBancaria.Domain.Interfaces.Service;
using System.Collections.Generic;
using System.Web.Http;

namespace ProjetoContaBancaria.API.Controllers
{
    public class ContaController : ApiController
    {
        private readonly IContaService _contaService;

        public ContaController(IContaService contaService)
        {
            _contaService = contaService;
        }

        public void Delete(int Num_Conta)
        {
            _contaService.Delete(Num_Conta);
        }

        public Conta Get(int Num_Conta)
        {
            return _contaService.Get(Num_Conta);
        }
        [HttpGet, Route(template: "api/conta/getcontas")]
        public List<Conta> GetContas(int Num_Cpf)
        {
            return _contaService.GetContas(Num_Cpf);
        }

        public string Post(Conta conta)
        {
            _contaService.Post(conta);
            return "";
        }
    }
}
